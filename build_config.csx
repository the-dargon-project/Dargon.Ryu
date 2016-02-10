var projects = Projects("ryu", "commons");

Export.Solution(
   Name: "Ryu IoC",
   Commands: new ICommand[] {
      Build.Projects(projects),
      Test.Projects(projects)
   }
);