namespace Session03_AssignmentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1
            // a) method overload: more than one method in the same class have the same name but defer in number of parameters, datatypes,
            // and the rearange of datatype
            // method override: when a child want to change behavior of the parent's method, so the override method in child class, can
            // use keyword new or override

            // b) static binding: by using keyword new, happened in compilation time, and calling based on parent
            // dynamic binding: by using keyword override, happened in runtime, and calling based on child
            #endregion

            #region Q2
            // a) it prevents the inheritance of this class
            // b) sealed class prevents the inheritance of this class, but sealed method prevents the override of this method in the
            // child class
            // c) no, because the keyword sealed when applied to method so it prevents the method from overriding in any child
            #endregion
            #endregion
        }
    }
}
