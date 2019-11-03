<template>
  <div>
    <v-container fluid>
        <v-row
          align="center"
          justify="center"
        >
          <v-col cols="10">
            <v-card>
              <v-card-text>
                <h3>Click to test http call</h3>
                <v-btn class="mx-2" fab dark small color="pink" v-on:click="loadTestRecords">
                  <v-icon dark>mdi-phone</v-icon>
                </v-btn>
                <p>{{testRecords}}</p>
              </v-card-text>
            </v-card>
          </v-col>
        </v-row>
    </v-container>
  </div>
</template>

<script>
export default {
  name: 'HttpExample',
  props: {
    testRecords: Array,
  },
  methods: {
    loadTestRecords() {
      const uri = 'http://localhost:54132/testrecord';

      this.$http.get(`${uri}`)
        .then((response) => {
          this.testRecords = response.data;
        })
        .catch(error => error);
    },
  },
};
</script>
