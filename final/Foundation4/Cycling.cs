class Cycling : Activity {
    private double speed; // in mph

    public Cycling(DateTime date, int length, double speed) : base(date, length) {
        this.speed = speed;
    }

    public override double GetSpeed() {
        return speed;
    }

    public override double GetDistance() {
        return speed * (length / 60.0);
    }

    public override double GetPace() {
        return 60.0 / speed;
    }

    public override string GetSummary() {
        return $"{base.GetSummary()} Cycling ({length} min)- Distance {GetDistance():F1} miles, Speed: {speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}