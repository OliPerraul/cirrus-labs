import 'phaser'

export default class Scene extends Phaser.Scene {
    constructor() {
        super('Game');
    }
    
    preload() {
        this.load.image('logo', "./src/help.png");
    }

    create() {
        var logo = this.add.image(400, 150, "logo");
    }
}