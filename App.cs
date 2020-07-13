namespace AcadAddinManager
{
    using Autodesk.AutoCAD.Runtime;

    class App : IExtensionApplication
    {
        public void Initialize()
        {
            "Add to AddinManager. Command:\nAddinManager - Select Command,\nAddinManagerLast - Run Commmand Last.".Write();
            AddinManagerService.ClearAddins();
        }

        public void Terminate()
        {
            AddinManagerService.ClearAddins();
        }
    }
}