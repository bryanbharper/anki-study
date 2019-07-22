import unittest


def binary_search(list, item):
    # Implement Here
    return 0


class TestBinarySearch(unittest.TestCase):

    def test_binary_search_returnsIndexOfElement_WhenPresent(self):
        # Arrange
        mylist = [1, 3, 5, 7, 9]
        item = 3

        # Act
        result = binary_search(mylist, item)

        # Assert
        self.assertEqual(result, 1)

    def test_binary_search_returnsNone_WithElementAbsent(self):
        # Arrange
        mylist = [1, 3, 5, 7, 9]
        item = -1

        # Act
        result = binary_search(mylist, item)

        # Assert
        self.assertEqual(result, None)


if __name__ == '__main__':
    unittest.main()
