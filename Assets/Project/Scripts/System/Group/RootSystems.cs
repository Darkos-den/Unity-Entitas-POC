using Entitas;

public class RootSystems : Feature {
    
    public RootSystems(GameContext context) {
        Add(new HighlightInputSystem(context));

        Add(new HighlightRenderSystem(context));
        Add(new HighlightCleanSystem(context));

        Add(new ItemSelectionInputSystem(context));
        Add(new ItemRenderSystem(context));

        Add(new InitializeGameSystem(context));
        Add(new WinCheckSystem(context));
    }
}
