namespace DesignPattern.BehavioralPattern.CommandPatterm;

public class Player
{
    public int Hp { get; private set; }
    public int X { get; private set; }
    public int Y { get; private set; }

    public Player(int hp, int x, int y) {
        Hp = hp;
        X = x;
        Y = y;
    }

    public void Move(int x, int y) {
        X += x;
        Y += y;
    }

    public void TakeDamage(int damage) {
        Hp -= damage;
    }

    public override string ToString() {
        return $"hp: {Hp}, position: ({X}, {Y})";
    }
}