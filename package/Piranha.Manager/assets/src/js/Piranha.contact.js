/*global
    piranha
*/

piranha.contact = new Vue({
    el: "#contacts",
    data: {
        loading: true,
        contentId: null,
        items: [],
        state: "all"
    },
    computed: {
        filteredItems: function () {
            var self = this;

            return this.items.filter(function (item) {
                if (self.state === "all") {
                    return true;
                } 
            });
        }
    },
    methods: {
        load: function (id) {
            var self = this;

            if (!id) {
                id = "";
            }

            fetch(piranha.baseUrl + "manager/api/contact/" + id)
                .then(function (response) { return response.json(); })
                .then(function (result) {
                    self.contentId = result.contentId;
                    self.items = result.contacts;
                })
                .catch(function (error) { console.log("error:", error ); });
        },
        remove: function (id) {
            var self = this;

            fetch(piranha.baseUrl + "manager/api/contact/delete/" + id)
                .then(function (response) { return response.json(); })
                .then(function (result) {
                    // Push status to notification hub
                    piranha.notifications.push(result);

                    // Refresh the list
                    self.load(self.contentId);
                })
                .catch(function (error) { console.log("error:", error ); });
        },
        setStatus: function (status) {
            this.state = status;
        }
    },
    updated: function () {
        this.loading = false;
    }
});
