var app = new Vue({
    el: '#app',
    data: {
        isanimalhungry: true,
        animal: {
            id: 0,
            type: "type",
            name: "name",
            healthPoints: "health",
            health: 0,
            damageTaken: 0,
            healthPointsRecieved: 0,
            isAlive: true,
        },
        animals: []
    },

    mounted() {
        this.getAnimals();
    },
    methods: {
        getAnimals() {
            console.log("Outside get all function");
            axios.get("/Home/GetAll")
                .then(res => {
                    console.log(res);
                    console.log("Inside get all function");
                    this.animals = res.data;
                })
                .catch(err => {
                    console.log(err);
                });

        },
        getAnimalsSurvivors() {
            console.log("Outside get all function");
            axios.get("/Home/GetAllSurvivors")
                .then(res => {
                    console.log(res);
                    console.log("Inside get all function");
                    this.animals = res.data;
                })
                .catch(err => {
                    console.log(err);
                });

        },
        feedAnimal() {
            console.log("Outside Feed function function")
            axios.post("/Home/Update/" + this.isanimalhungry)
                .then(res => {
                    console.log("Inside starve function")
                    console.log(res);
                    this.getAnimals();
                })
                .catch(err => {
                    console.log(err);
                });
        },
        starveAnimal() {
            console.log("Outside starve function")
            axios.post("/Home/Update/" + !this.isanimalhungry)
                .then(res => {
                    console.log("Inside starve function")
                    console.log(res);
                    this.getAnimals();
                })
                .catch(err => {
                    console.log(err);
                });

        },
        reset() {
            axios.get("/Home/Reset")
                .then(res => {
                    this.getAnimals();
                })
                .catch(err => {
                    console.log(err);
                });

        },
        animalsAlive() {
        }
    },
})