from create_video_list import CreateVideoList

class TestCreateVideoList(CreateVideoList):
    def __init__(self, window):
        super().__init__(window)

    def add_video_to_playlist(self):
        return super().add_video_to_playlist()
    
    def test_add_video_to_playlist(self):
        TestCreateVideoList.add_video_to_playlist(self)

def test_add_video():
    t = TestCreateVideoList
    t.add_video_to_playlist
    t.test_add_video_to_playlist










    
    
    

    
