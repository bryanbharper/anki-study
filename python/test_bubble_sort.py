import unittest


def bubble_sort(list):
    pass


class TestBubbleSort(unittest.TestCase):

    def test_bubble_sort(self):
        # Arrange
        mylist = [29, 10, 14, 37, 14]

        # Act
        bubble_sort(mylist)

        # Assert
        self.assertEqual(mylist,  [10, 14, 14, 29, 37])


if __name__ == '__main__':
    unittest.main()
