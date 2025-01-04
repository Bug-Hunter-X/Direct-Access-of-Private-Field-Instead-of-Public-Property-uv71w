# Direct Access of Private Field Instead of Public Property

This repository demonstrates an uncommon C# bug.  The `bug.cs` file shows code that directly accesses a private field instead of using its corresponding public property.  This can lead to unexpected behavior, particularly if the property includes validation or other logic.

The `bugSolution.cs` file provides a corrected version, consistently utilizing the public property.

This example highlights the importance of consistently using properties to access and modify class members to maintain code consistency, readability, and to leverage any additional logic within properties.