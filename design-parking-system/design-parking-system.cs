public class ParkingSystem {
    int[] count;
    public ParkingSystem(int big, int medium, int small) {
        count= new int[]{ big, medium, small };
    }
    
    public bool AddCar(int carType) {
        count[carType-1]-= 1;
        return count[carType-1] >= 0 ;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */