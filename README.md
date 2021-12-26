# Huffman Coding

Huffman is a source coding technique for lossless data compression. It is a variable-length encoding scheme. 

It assigns shorter codes to more frequent symbols and longer codes to less frequent symbols.

## Example
Consider a text file that uses only five characters (A, B, C, D, E)

|     Character    |      A    |      B    |      C    |      D    |      E    |
|:----------------:|:---------:|:---------:|:---------:|:---------:|:---------:|
|     Frequency    |     17    |     12    |     12    |     27    |     32    |

=> Total Characters in the file = 100

#### Step 1 : Find probability. 

|     Character    |     Frequency    |     Probability    |
|:----------------:|:----------------:|:------------------:|
|         A        |         17       |         0.17       |
|         B        |         12       |         0.12       |
|         C        |         12       |         0.12       |
|         D        |         27       |         0.27       |
|         E        |         32       |         0.32       |

#### Step 2 : Sort.

|     Character    |     Frequency    |     Probability    |
|:----------------:|:----------------:|:------------------:|
|         E        |         32       |         0.32       |
|         D        |         27       |         0.27       |
|         A        |         17       |         0.17       |
|         B        |         12       |         0.12       |
|         C        |         12       |         0.12       |

#### Step 3 : Partition #1.

|     Character    |      Probability    |          |
|:----------:|:-----------:|:--------:|
|      E     |     0.32    |          |
|      D     |     0.27    |          |
|      A     |     0.17    |          |
|      B     |     0.12    |     0    |
|      C     |     0.12    |     1    |

#### Step 4 : Partition #2.

|     Character    |     Probability    |          |
|:----------:|:-----------:|:-------:|
|      E     |     0.32    |         |
|      D     |     0.27    |         |
|      BC    |     0.24    |    0    |
|      A     |     0.17    |    1    |

#### Step 5 : Partition #3. 

|     Character    |     Probability    |          |
|:----------:|:-----------:|:-------:|
|     BCA    |     0.41    |         |
|      E     |     0.32    |    0    |
|      D     |     0.27    |    1    |

#### Step 6 : Partition #4. Final Encoding. 

|     Character    |     Probability    |         |
|:----------:|:-----------:|:-------:|
|      ED    |     0.59    |    0    |
|     BCA    |     0.41    |    1    |


