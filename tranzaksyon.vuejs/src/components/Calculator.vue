<template>
  <div class="row">
    <div class="col-auto">
      <label class="form-label" for="form-price">Price:</label>
      <input type="number" id="form-price" class="form-control" v-model="price"/>
    </div>

    <div class="col-auto">
      <label class="form-label" for="form-price">Type:</label>
      <select id="form-price" class="form-select" v-model="selectedType">
        <option :value="null">Select a vehicule type</option>
        <option :value="0">Common</option>
        <option :value="1">Luxury</option>
      </select>
    </div>

    <div class="col">
      <CalculatorResult :price="price" :vehicule="vehicule" v-if="vehicule"></CalculatorResult>
    </div>
  </div>
</template>

<script setup lang="ts">
import {ref, inject, computed} from 'vue';
import VehiculeApi from '../apis/VehiculeApi';
import CalculatorResult from './CalculatorResult.vue'

let selectedType = ref(null);
let price = ref(0);

const vehiculeApi = inject(VehiculeApi.PROVIDER_KEY);

const vehicules = await vehiculeApi.getVehicules();

const vehicule = computed(() => {
  return vehicules.find(v => v.vehicleType === selectedType.value);
});
</script>