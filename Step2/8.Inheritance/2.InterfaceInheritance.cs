using InterfaceInheticanceBasics;

namespace InterfaceInheticanceBasics
{
    interface Interface1
    {
        int property1 { get; set; }
        int Method1();

        string Method2();
        string Method3(int a, int b);

    }

    interface Interface3
    {
        string Method4();

    }

    //one interface can inherite from multiple class
    interface Interface2 : Interface1, Interface3
    {
        string Method5();
    }
}