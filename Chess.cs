using System;

public static class Chess
{
    // TODO: inicia a posição, administra a vez de cada jogador e checa checkmates e repetições
    public delegate void SelectorHandler(object sender, EventArgs e);
    public static event SelectorHandler OnSelection;

    public static void TriggerSelector()
    {
        if(OnSelection != null)
        {
            OnSelection(null,null);
        }
    }

}