#region Copyright (C) 2005-2011 Team MediaPortal

// Copyright (C) 2005-2011 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MediaPortal is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MediaPortal is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#endregion

using MediaPortal.Dialogs;
using MediaPortal.GUI.Library;
using MediaPortal.Music.Database;

namespace MediaPortal.GUI.Music
{
  /// <summary>
  /// 
  /// </summary>
  public class GUIMusicArtistInfo : GUIDialogWindow
  {
    [SkinControl(6)] protected GUIButtonControl btnRefresh = null;

    private bool m_bRefresh = false;
    private MusicArtistInfo artistInfo = null;

    public GUIMusicArtistInfo()
    {
      GetID = (int)Window.WINDOW_ARTIST_INFO;
    }

    public override bool Init()
    {
      return Load(GUIGraphicsContext.GetThemedSkinFile(@"\DialogArtistInfo.xml"));
    }

    public override void DoModal(int ParentID)
    {
        m_bRefresh = false;
        AllocResources();
        InitControls();
        
        base.DoModal(ParentID);
    }

    protected override void OnPageDestroy(int newWindowId)
    {
      artistInfo = null;
      base.OnPageDestroy(newWindowId);
    }

    protected override void OnPageLoad()
    {
      base.OnPageLoad();

      GUIPropertyManager.SetProperty("#ArtistInfo.Artist", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.Bio", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.Born", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.Genres", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.Instruments", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.Styles", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.Tones", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.YearsActive", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.Albums", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.Compilations", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.Singles", string.Empty);
      GUIPropertyManager.SetProperty("#ArtistInfo.MiscAlbums", string.Empty);

      Refresh();
    }

    protected override void OnClicked(int controlId, GUIControl control, Action.ActionType actionType)
    {
      base.OnClicked(controlId, control, actionType);
      if (control == btnRefresh)
      {
        m_bRefresh = true;
        PageDestroy();
        return;
      }
    }

    public MusicArtistInfo Artist
    {
      set { artistInfo = value; }
    }

    private void Update()
    {
      if (null == artistInfo)
      {
        return;
      }

      GUIPropertyManager.SetProperty("#ArtistInfo.Artist", artistInfo.Artist);
      GUIPropertyManager.SetProperty("#ArtistInfo.Bio", artistInfo.AMGBiography);
      GUIPropertyManager.SetProperty("#ArtistInfo.Born", artistInfo.Born);
      GUIPropertyManager.SetProperty("#ArtistInfo.Genres", artistInfo.Genres);
      GUIPropertyManager.SetProperty("#ArtistInfo.Instruments", artistInfo.Instruments);
      GUIPropertyManager.SetProperty("#ArtistInfo.Styles", artistInfo.Styles);
      GUIPropertyManager.SetProperty("#ArtistInfo.Tones", artistInfo.Tones);
      GUIPropertyManager.SetProperty("#ArtistInfo.YearsActive", artistInfo.YearsActive);
      GUIPropertyManager.SetProperty("#ArtistInfo.Albums", artistInfo.Albums);
      GUIPropertyManager.SetProperty("#ArtistInfo.Compilations", artistInfo.Compilations);
      GUIPropertyManager.SetProperty("#ArtistInfo.Singles", artistInfo.Singles);
      GUIPropertyManager.SetProperty("#ArtistInfo.MiscAlbums", artistInfo.Misc);
    }


    private void Refresh()
    {
      string coverArtUrl = artistInfo.ImageURL;
      string coverArtFileName = GUIMusicBaseWindow.GetArtistCoverArtName(artistInfo.Artist);
      // do not overwrite existing artist thumb
      if (!string.IsNullOrEmpty(coverArtFileName) && !Util.Utils.FileExistsInCache(coverArtFileName))
      {
        //	Download image and save as permanent thumb
        Util.Utils.DownLoadImage(coverArtUrl, coverArtFileName);
      }

      Update();
    }

    public bool NeedsRefresh
    {
      get { return m_bRefresh; }
    }

  }
}