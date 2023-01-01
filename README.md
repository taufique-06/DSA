# DSA

1. Binary Search - Only implement this one when array is sorted. In addition, you need to make sure whether the array is in ascending or descending (Order-agnostic Binary Search)

  1.1 - Binary Search Related Questions:
  
    1.1.1 - Ceiling of a given number - The ceiling function of a number is the least integer number greater than or equal to the given number
    1.1.2 - Floor of a given number - Given a sorted array and a value x, the floor of x is the largest element in the array smaller than or equal to x
    1.1.3 - Find the Smallest letter greater than the target - Given a charcters array letters that is sorted in non-decreasing(Ascending) order and a character target, return the smallest character in the array that is larger than the target
    1.1.4 - Find First and Last Position of Element in Sorted Array - https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/ (Answer not included in this repo, Answer can be found on my Leetcode account)
    1.1.5 - Find position of an element in a sorted array of infinite numbers
    1.1.6 - Peak Index in a Mountain Array
      What is Mountain Array? Mountain Array also known as bitonic array which value first increases and then decreases. For example int[] arr = {2,4,6,8,10, 6,4,3,2};
      Now, which algorithm can be used? Binary Search as it can be seen that first half is sorted in ascending order and second half is sorted in descending order. 
    1.1.7 - Find Peak Element https://leetcode.com/problems/find-peak-element/
    1.1.8 - Find in Mountain Array: https://leetcode.com/problems/find-in-mountain-array/
    1.1.9 - Search in Rotated Sorted Array: https://leetcode.com/problems/search-in-rotated-sorted-array/
      What is Rotated Array?
        -Let's Clear with a example
        int[] arr = {2,4,6,8,10,12} (This array is unrotated)
        int[] arr = {12,2,4,6,8,10} (This is the array after 1st rotation)
        int[] arr = {12,10,2,4,6,8} (This is the array after 2nd rotation) 
 
 2. Bubble Sort - comparison-based algorithm in which each pair of adjacent elements is compared and the elements are swapped if they are not in order. While doing that,                   with the first pass through the array, the largest come to the very end. 
 3. Selection Sort - Find the largest element and put it its current index. Or find the smallest element and put it its current index
 4. Insertion Sort - In simple terms: if you have an array with 5 elements, then this algorithm will sort first 2 elements first. Then first 3 elements, then first 4 elements and then first 5 elements. It is good to use when the array is partially sorted. 

![image](https://user-images.githubusercontent.com/85470428/209861651-d44e428d-2072-4f06-9c42-4dbb538cf0ab.png)

5. Cyclic Sort - Cycle sort is a comparison sorting algorithm which forces array to be factored into the number of cycles where each of them can be rotated to produce a sorted array. This algorithm should be used when given numbers from range 1 to N. So whenever there is a question which say something that is in range from 1 to N, cyclic sort should be used. 
  
  Note: In cylic sort, when you are getting array from range 1 to N, then the currentIndex will be arr[i] - 1. However, if the given numbers from 0 to N, then                 currentIndex = arr[i]. In other words, from range 1 to N, the value is equal to index + 1.
  
  5.1 Sort Related Questions:
  
    5.1.1 - https://leetcode.com/problems/missing-number/
    5.1.2 - https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
    5.1.3 - https://leetcode.com/problems/find-the-duplicate-number/
    5.1.4 - https://leetcode.com/problems/find-all-duplicates-in-an-array/
    5.1.5 - https://leetcode.com/problems/set-mismatch/
    5.1.6 - https://leetcode.com/problems/first-missing-positive/ (Havent finished yet)
