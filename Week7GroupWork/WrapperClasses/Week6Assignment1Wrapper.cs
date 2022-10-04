using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7GroupWork.Services;
using Week7GroupWork.WrapperClasses.ApplicationClasses;

namespace Week7GroupWork.WrapperClasses
{
    public class Week6Assignment1Wrapper
    {
        Week6Assignment1 logicLayerClass;

        public Week6Assignment1Wrapper()
        {
            // default storage size is 10
            logicLayerClass = new Week6Assignment1(10);
        }

        public Week6Assignment1Wrapper(Week6Assignment1 logicLayerClass)
        {
            this.logicLayerClass = logicLayerClass;
        }

        public void Run()
        {
            //ZConsole.DrawBox()
        }

        public void FullExecute()
        {
            Console.WriteLine("Welcome to Week6Assignment1 App!");
            logicLayerClass.PromptInputStorageSize();
            logicLayerClass.PromptInputRectangles();
            logicLayerClass.PromptInputTriangles();
            logicLayerClass.PromptInputCircles();
            ShowStorageContent();
        }

        public void PartialExecute()
        {
            Console.WriteLine("Welcome to Mini-Week6Assignment1 App!");
            logicLayerClass.PromptInputRectangles();

        }

        public void ShowStorageContent()
        {
            Console.WriteLine("=============== SHAPES =============");
            logicLayerClass.ShowAllShapes();
        }


    }
}
