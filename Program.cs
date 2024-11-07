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

bool CheckMeteorShowerSize(int seed, int minSize, int maxSize) {
  var random = new Random(seed + 12);

  var size = random.Next(0, 100);
  return minSize <= size && size <= maxSize;
}

int seedCount = 0;

while (true) {
  var seed = new Random().Next(1, 100000001);

  if (! CheckMeteorShowerChance(seed)) {
    continue;
  }

  if (! CheckMeteorShowerTime(seed, 5, 5)) {
    continue;
  }

  Console.WriteLine(seed);

  seedCount += 1;
  if (seedCount >= 100) {
    break;
  }
}
