from create_video_list import CreateVideoList

def test_add_video_to_playlist(self):
    # Test case 1: Add a valid video to the playlist.
    # Given a video number, add it to the playlist.
    number_to_add = "1"
    # When the video number is valid, the video is added to the playlist and the play count is displayed.
    self.playlist = []
    CreateVideoList.add_video_to_playlist(self, number_to_add)
    self.assertEqual(self.playlist, ["Tom and Jerry"])
    self.assertEqual(self.playlist_txt.get(), "Fred Quimby")
    self.assertEqual(self.messagebox_txt.get(), "Play count: 1")
    # Test case 2: Add an invalid video to the playlist.
    # Given a video number, add it to the playlist.
    number_to_add = "1000"
    # When the video number is invalid, the video is not added to the playlist and an error message is displayed.
    self.playlist = []
    CreateVideoList.add_video_to_playlist(self, number_to_add)
    self.assertEqual(self.playlist, [])
    self.assertEqual(self.playlist_txt.get(), "Video 1000 not found")
    self.assertEqual(self.messagebox_txt.get(), "Error: Video 1000 not found")
