public class RootSystems : Feature {
    
    public RootSystems(GameContext context) {
        Add(new HighlightInputSystem(context));
        Add(new ItemSelectionInputSystem(context));

        Add(new InitializeGameSystem(context));
        Add(new WinCheckSystem(context));
    }
}
