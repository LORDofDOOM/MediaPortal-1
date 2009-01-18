#region Copyright (C) 2005-2008 Team MediaPortal

/* 
 *	Copyright (C) 2005-2008 Team MediaPortal
 *	http://www.team-mediaportal.com
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *   
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *   
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA. 
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */

#endregion

#**********************************************************************************************************#
#
# This header contains multilanguage strings for the setup routine
#
#**********************************************************************************************************#

# ENGLISH
LangString DESC_SecGabest                         ${LANG_ENGLISH} "Installs the MPC-HC audio/video decoders"
LangString ^UninstallLink                         ${LANG_ENGLISH} "Uninstall $(^Name)"

LangString TEXT_MSGBOX_REMOVE_ALL                 ${LANG_ENGLISH} "!!! ATTENTION !!!$\r$\nDo you want to make a complete cleanup?$\r$\nThis removes completly the registry keys, the installation and the common app data directory, inclusive thumbs, databases, skins and plugins!"
LangString TEXT_MSGBOX_REMOVE_ALL_STUPID          ${LANG_ENGLISH} "!!! ATTENTION !!!$\r$\nAgain for those who slept the msgBox before. :( $(TEXT_MSGBOX_REMOVE_ALL)"

LangString TEXT_MSGBOX_ERROR_MP022                ${LANG_ENGLISH} "Old MSI-based MediaPortal 0.2.2.0 is still installed. Why didn't you follow the instructions and didn't remove it first? Do that and restart this setup."
LangString TEXT_MSGBOX_ERROR_MP023RC3             ${LANG_ENGLISH} "Old MediaPortal 0.2.3.0 RC3 is still installed. Why didn't you follow the instructions and didn't remove it first? Do that and restart this setup."
LangString TEXT_MSGBOX_ERROR_MP023                ${LANG_ENGLISH} "Old MediaPortal 0.2.3.0 is still installed. Why didn't you follow the instructions and didn't remove it first? Do that and restart this setup."


LangString TEXT_MSGBOX_ERROR_SVN_NOMP             ${LANG_ENGLISH} "MediaPortal 1.0 RC1 is not installed. You need to install this before you can install an svn snapshot."
