class Earth:
    def __init__(self, G:float=6.673e-11, Radius:float=6.3781e6, Mass:float=5.97e24):
        self.G = G
        self.Radius = Radius
        self.Mass = Mass

    
    def earth_info(self):
        return f"Earth: G = {self.G}, Radius = {self.Radius}, Mass = {self.Mass}"