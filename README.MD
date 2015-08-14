Merged into [kasthack.Performance](https://github.com/old-kasthack-s-projects/kasthack.Performance)
=======================



StructStrings
=============

Compact storage structures for short ASCII strings.
I've implemented 8,16,24 and 32-char versions.

Difference between struct/standard strings:

System.String:
  Size:
    header:         18 bytes
    bytes-per-char: 2
    charset:        unicode
    max-length:     int.MaxValue
String8:
  Size:
    bytes-per-char: 1
    charset:        ascii
    max-length:     8
String16:
  Size:
    bytes-per-char: 1
    charset:        ascii
    max-length:     16
String24:
  Size:
    bytes-per-char: 1
    charset:        ascii
    max-length:     24
String32:
  Size:
    bytes-per-char: 1
    charset:        ascii
    max-length:     32 
