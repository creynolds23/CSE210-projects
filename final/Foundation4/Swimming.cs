class Swimming : Activity {
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length) {
        this.laps = laps;
    }

    public override double GetDistance() {
        return laps * 50 / 1000.0;
    }

    public override double GetSpeed() {
        return GetDistance() / (length / 60.0);
    }

    public override double GetPace() {
        return (length / 60.0) / GetDistance();
    }

    public override string GetSummary() {
        return $"{base.GetSummary()} Swimming ({length} min)- Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}