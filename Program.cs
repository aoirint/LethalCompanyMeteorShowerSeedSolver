bool CheckMeteorShowerChance(int seed) {
  var meteorShowerChance = 7;
  var random = new Random(seed + 28);

  return random.Next(0, 1000) < meteorShowerChance;
}

bool CheckMeteorShowerTime(int seed, int minTime, int maxTime) {
  var random = new Random(seed + 28);
  random.Next(0, 1000);

  var time = random.Next(5, 80);
  return minTime <= time && time <= maxTime;
}

// NOTE: Possible max seed is 100000000.
for (var seed = 0; seed < 100000001; seed++) {
  if (! CheckMeteorShowerChance(seed)) {
    continue;
  }

  // NOTE: Change minTime, maxTime in [5, 79] to select the time of Meteor shower. e.g. Use minTime=5 maxTime=5 for the start of day.
  if (! CheckMeteorShowerTime(seed, 5, 79)) {
    continue;
  }

  Console.WriteLine(seed);
}

