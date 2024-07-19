<template>
    <div class="container mt-3">
        <suspense>
            <calculator></calculator>

            <template #fallback>
                <div class="text-center">
                    <font-awesome-icon :icon='["fas", "spinner"]' :spin="true" class="fs-1"></font-awesome-icon>
                </div>
            </template>
        </suspense>
    </div>
</template>

<script setup lang="ts">
    import { provide, ref } from 'vue';
    import calculator from './components/Calculator.vue';
    import VehiculeApi from './apis/VehiculeApi';

    provide(VehiculeApi.PROVIDER_KEY, new VehiculeApi());
</script>



<style scoped>
</style>
