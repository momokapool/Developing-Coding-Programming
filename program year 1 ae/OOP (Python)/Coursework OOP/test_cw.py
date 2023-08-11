from create_video_list import CreateVideoList
from video_library import LibraryItem


class CRVTestCase():
    def __init__(self):
        self.item = LibraryItem("Test", "One", 1)
        self.library = []

    def test_add_video_to_playlist(self):
        test = CreateVideoList
        test.add_video_to_playlist(self.library)
        assert self.library[1] == ("Test", "One", 1)


def test_add_video_to_playlist():
    crvtest = CRVTestCase()
    crvtest.test_add_video_to_playlist
        

    
    


















    
    
    

    
