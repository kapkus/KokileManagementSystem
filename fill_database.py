import sqlite3
import sys

# generate all possible variations for given pattern
def generate_variations(pattern):
    variations = []
    n = pattern.count('0')
    for i in range(2 ** n):
        binary_i = format(i, f'0{n}b')
        variation = ''
        j = 0
        for char in pattern:
            if char == '0':
                variation += binary_i[j]
                j += 1
            else:
                variation += char
        variations.append(variation)
    return variations

def main(database_path):

    conn = sqlite3.connect(database_path)
    cursor = conn.cursor()

    patterns = [
        '1000000001000100000001',
        '100000000100000001'
    ]

    for pattern in patterns:
        variations = generate_variations(pattern)
        for i, variation in enumerate(variations):
            cursor.execute("INSERT INTO barcodes (barcode) VALUES (?)", (variation,))

    conn.commit()
    conn.close()

if __name__ == "__main__":
    if len(sys.argv) != 2:
        print("Usage: python fill_database.py <database_path>")
        sys.exit(1)

    database_path = sys.argv[1]
    main(database_path)