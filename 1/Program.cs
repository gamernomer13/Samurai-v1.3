using System;

namespace _1
{
   
     class A
    {

    }
     class C:A
    {
       protected object first;
        public C(object first)
        {
            this.first = first;
        }

    }

     class B : C
    {
       protected object second;
        public B(object first,object second):base(first)
        {
            this.first = first;
            this.second = second;
        }
    }   
    class program
    {
        object a = new A();
        B b = new B(new C(a), new B(a, new C(a)));
    }
     
}
