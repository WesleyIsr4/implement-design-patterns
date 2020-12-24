const car = {
  noOfWheels: 4,
  start() {
    return "started";
  },
  stop() {
    return "stopped";
  },
};

const myCar = Object.create(car, { owner: { value: "Wesley" } });

console.log(myCar.__proto__ === car);
