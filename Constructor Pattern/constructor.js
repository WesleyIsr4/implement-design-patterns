// Função tradicional de syntax

// function Hero(name, specialAbility) {
//   this.name = name;
//   this.specialAbility = specialAbility;

//   this.getDetails = function () {
//     return this.name + " can " + this.specialAbility;
//   };
// }

// ES6 classes syntax

class Hero {
  constructor(name, specialAbility) {
    // configurando o valor da propriedade name
    this._name = name;
    this._specialAbility = specialAbility;

    // Declarando o metodo do objeto

    this.getDetails = function () {
      return `${this._name} can ${this._specialAbility}`;
    };
  }
}

const Hulk = new Hero("Hulk", "Force");

console.log(Hulk.getDetails());
