import unittest


def quick_sort(list, lo, hi):
    pass


class TestQuickSort(unittest.TestCase):

    def test_quick_sort(self):
        # Arrange
        mylist = [29, 10, 14, 37, 14]

        # Act
        quick_sort(mylist, 0, len(mylist)-1)

        # Assert
        self.assertEqual(mylist, [10, 14, 14, 29, 37])


if __name__ == '__main__':
    unittest.main()
