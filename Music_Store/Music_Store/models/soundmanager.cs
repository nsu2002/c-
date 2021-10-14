using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.models
{
    class soundmanager
    {
        public static void GetAllSounds(ObservableCollection<sound> sounds)
        {
            var allSounds = GetSounds();
            sounds.Clear();
            allSounds.ForEach(a => sounds.Add(a));

        }
        public static void GetAllSoundsByName(ObservableCollection<sound> sounds, string name)
        {
            var allSounds = GetSounds();
            var filterSound = allSounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filterSound.ForEach(a => sounds.Add(a));

        }
        public static List<sound> GetSounds()
        {
            var sounds = new List<sound>();
            sounds.Add(new sound("Anh Thề đấy", "y2mate.com - Anh Thề Đấy  Thanh HưngCukak Remix Audio Lyrics Video.mp3", "zingmp3.png"));
            sounds.Add(new sound("Cưới Đi", "y2mate.com - 2T  CƯỚI ĐI Changg Ft Yang Remix  Bản Remix Vinahouse Phiêu Không Lối Thoát  OFFICIAL AUDIO.mp3", "zingmp3.png"));
            sounds.Add(new sound("Có Hẹn Với Thanh Xuân", "y2mate.com - Có Hẹn Với Thanh Xuân  MonstarCukak Remix Audio Lyrics Video.mp3 (1).webm", "zingmp3.png"));
            sounds.Add(new sound("Thế Lương", "y2mate.com - Thê Lương  Phúc Chinh  KProx Remix   Nhạc Trẻ EDM Tik Tok Gây Nghiện Hay Nhất.mp3", "zingmp3.png"));
            sounds.Add(new sound("Hạ Còn Vương Nắng", "y2mate.com - HẠ CÒN VƯƠNG NẮNG  DATKAA x KIDO x Prod QT BEATZ OFFICIAL MUSIC VIDEO.mp3", "zingmp3.png"));
            sounds.Add(new sound("Chiều Hôm ấy", "y2mate.com - JayKii  CHIỀU HÔM ẤY Official MV.mp3", "zingmp3.png"));
            sounds.Add(new sound("Kẹo Bông Gòn", "y2mate.com - Kẹo Bông Gòn  H2K ft TrunkyCukak Remix Audio Lyrics Video.mp3", "zingmp3.png"));
            sounds.Add(new sound("Nụ Cười 18 20", "y2mate.com - Nụ Cười 18 20  Doãn Hiếu Official  Hãy hết mình trên con đường ta chọn hẹn gặp khi thành công.mp3", "zingmp3.png"));

            sounds.Add(new sound("Forget Me Nơ", "y2mate.com - Forget Me Now  Fishy ft Trí DũngCukak Remix Audio Lyrics.mp3", "zingmp3.png"));
            sounds.Add(new sound("Nụ Cười 18 20", "y2mate.com - Nụ Cười 18 20  Doãn Hiếu Official  Hãy hết mình trên con đường ta chọn hẹn gặp khi thành công.mp3", "zingmp3.png"));


            return sounds;
        }
    }
}
