using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> weNeedshapes) // here the parameter for DrawShapes
                                                   // is a generic list of Shapes
        {
            foreach (var shape in weNeedshapes)
            {
                shape.Draw();   // Here the Canvas class does not know what are the 
                                // shapes that are being drawn 




                /* previous code wwith enumerating 
                 * switch (shape.Type)
                 * {
                 *   case ShapeType.Circle:
                 *   Console WriteLine("Draw a circle");
                 *   break; 
                 * 
                 */
            }
        }
    }
}