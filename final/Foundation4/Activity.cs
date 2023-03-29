class Activity {
    private DateTime currentdate = DateTime.Today;
    public int length; // in minutes

    public Activity(DateTime date, int length) {
        currentdate = date;
        this.length = length;
    }

    public virtual double GetDistance() {
        return 0;
    }

    public virtual double GetSpeed() {
        return 0;
    }

    public virtual double GetPace() {
        return 0;
    }

    public virtual string GetSummary() {
        return $"{currentdate.ToString("dd MMM yyyy")}";
    }
}