A collection of open-source Unity3D 4+ property drawers

http://blogs.unity3d.com/2012/09/07/property-drawers-in-unity-4/
http://docs.unity3d.com/Documentation/ScriptReference/PropertyDrawer.html

Each directory contains one drawer, and some documentation.

Got an idea for a drawer? No time? Suggest it in the issues page!
https://github.com/tenpn/ChestOfPropertyDrawers/issues

Pull requests more than welcome, but new drawers must be grainular enough to be of use to multiple projects.

New pull requests should be in this format:

```
AttributeName
 |- Editor
     |- PropertyDrawer.cs
 |- Attribute.cs
 |- ExampleUsage.cs
 |- readme.md
```

If you can embed pictures in your readmes, all the better.

Partially-inspired by this Japanese(?) repro:
https://github.com/anchan828/property-drawer-collection

Provided under the MIT License:

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
