# Hash-Array-Mapped-Trie
Implementation of a fast and space efficient Hash Array Mapped Trie in C# based on Philip Bagwell's paper, "Ideal Hash Trees".

Wrote this a couple years ago as a fun side project and am uploading now to Github in case anyone finds it interesting or useful.

## API 

### Add(TKey key, TValue value)

Adds the specified key and value to the HAMT

### Contains(TKey key)

Determines whether or not the given key is present in the HAMT

### Get(TKey key)

Returns the corresponding value based on the given key in the HAMT

### Clear

Clears the HAMT of all entries

### Examples

Run the `program.cs` file to test the code on the `dictionary.txt`. Outputs the time taken to add all the values, item count, check for the existence of every value, and the total memory usage.
