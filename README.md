# An Introduction to Ryu

Ryu is an extensible open-source .net IoC container released under Version 3 of the GNU Public License. 

## Ryu Modules
You register types with the IoC container through Ryu Modules.
```
public class DemoRobotRyuPackage : RyuModule {
  public DemoRobotRyuPackage() {
     Optional.Singleton<IterativeRobot>().Implements<IRobot>();
     Optional.Singleton<IterativeRobotConfiguration>(ConstructIterativeRobotConfiguration);
     ...
  }
  ...
}
```
Then instantiate Ryu and demand the container gives you singletons:
```
var ryu = new RyuFactory().Create();
var actualRobot = ryu.GetOrActivate<IRobot>();
actualRobot.Run();
```
You can also mark classes (e.g. services) as required so that they're automatically instantiated when a Ryu container initializes.

## Next Steps
Ryu's pretty barebones right now. You can check out older iterations to see where it's going. See [the-dargon-project repo](https://github.com/search?p=2&q=ryupackagev1&type=Code&utf8=%E2%9C%93).