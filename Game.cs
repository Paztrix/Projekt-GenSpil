using System;
using GenSpil;

public class Game
{
    private int id;
    public double price {  get; private set; }
    //private Condition condition;
    public GameType type {  get; private set; }

    public Game(int id, double price, GameType gametype)
    {
        this.id = id;
        this.price = price;
        //this.condition = condition;
        this.type = gametype;
    }

    public void Display() { }
    public void Checkout() { }

}
