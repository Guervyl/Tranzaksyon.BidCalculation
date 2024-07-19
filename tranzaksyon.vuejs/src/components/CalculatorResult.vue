<template>
  <div class="row" v-if="computedVehicule">
    <div class="col-12">
      <font-awesome-icon :icon='["fas", "spinner"]' :spin="true" v-if="isLoading"></font-awesome-icon>

      <table class="table table-striped table-hover" v-if="!isLoading">
        <tr>
          <th>Price</th>
          <td>{{ computedVehicule.basePrice }}</td>
        </tr>
        <tr>
          <th>Basic fee</th>
          <td>{{ computedVehicule.basicBuyerFee }} ({{ computedVehicule.basicBuyerFeePercentage * 100 }}%)</td>
        </tr>
        <tr>
          <th>Special fee</th>
          <td>{{ computedVehicule.sellersSpecialFee }} ({{ computedVehicule.sellersSpecialFeePercentage * 100 }}%)</td>
        </tr>

        <tr>
          <th>Association fee</th>
          <td>{{ computedVehicule.associationFee }}</td>
        </tr>

        <tr>
          <th>Storage fee</th>
          <td>{{ computedVehicule.storageFee }}</td>
        </tr>

        <tr>
          <th>Total</th>
          <th>{{ computedVehicule.total }}</th>
        </tr>
      </table>
    </div>
  </div>
</template>

<script setup lang="ts">
import {inject, ref, watch} from "vue";
import VehiculeApi from "@/apis/VehiculeApi";

const props = defineProps(["price", "vehicule"]);
let computedVehicule = ref(null);
const vehiculeApi = inject(VehiculeApi.PROVIDER_KEY) as VehiculeApi;
let isLoading = ref(true);

watch(() => props.price, async () => {
  await calculate();
});

watch(() => props.vehicule.vehicleType, async () => {
  await calculate();
});

async function calculate() {
  if (typeof (props.price) !== 'number' || props.price < 1) {
    alert('Price should be bigger than 1')
    return;
  }


  try {
    isLoading.value = true;
    const resp = await vehiculeApi.calculate(props.vehicule.vehicleType, props.price);
    computedVehicule.value = resp
  } catch (e) {
    alert('There was an error');
  } finally {
    isLoading.value = false;
  }
}

// Fetch on creation
calculate().then();
</script>