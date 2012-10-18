PGPS - A simple utility for generating C# properties

Current Version 1.1

I wanted a simple utility that would generate C# properties simply by typing the propertyname.  The utility would take care of choosing the datatype, comment, default values, get/set, raise "PropertyChanged", etc....

Each line in the input (the left side) becomes a property.

Here's the convention used:

- If there's only one word on the line, that word becomes the property name.  The default DataType is String.
- If there are two words on the line, the first word is the datatype, the second is the property name.
- If the line starts with an Xml Documentation ("///"), the documentation is carried to the public property.
- If the line starts with an Xml C# Comment ("//"), the comment is carried to the "private" field
- If there's a default value, the value is set on the private field.
- The private field's prefix is underscore ("_")

If you have to write one property, use Visual Studio's prop snippet.
If you have to write many, I think this utility good.  

Wishlist: I'd like to be able to choose different output style
1) All privates + all publics vs keep everything together
2) I like Laurent Bugnion's MVVMLight output of the mvvminpc snippet, this will be my next feature to implement.

History:
- 1.1: 2009.11.17 - Added INotifyPropertyChanged

- 1.0: 2006.05.29 - Created