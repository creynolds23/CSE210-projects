class Running : Activity {
    private double distance; // in miles

    public Running(DateTime date, int length, double distance) : base(date, length) {
        this.distance = distance;
    }

    public override double GetDistance() {
        return distance;
    }

    public override double GetSpeed() {
        return distance / (length / 60.0);
    }

    public override double GetPace() {
        return (length / 60.0) / distance;
    }

    public override string GetSummary() {
        return $"{base.GetSummary()} Running ({length} min)- Distance {distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}