!verbose 4
!include MUI2.nsh
Name "Batch Folder Creator Thingie"
OutFile "installer.exe"
InstallDir $LOCALAPPDATA\KoleSoft\BatchFolderCreator\


!define MUI_ABORTWARNING
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_LICENSE "License.txt"
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH
!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_UNPAGE_FINISH
!insertmacro MUI_LANGUAGE "English"

Section
	SetOutPath $INSTDIR
	File BatchFolderCreator.exe
	File BatchFolderCreator.exe.config
	WriteRegStr HKCU "SOFTWARE\Classes\Directory\Background\shell\BatchFolderCreator" "" "Create Multiple Folders"
	WriteRegStr HKCU "SOFTWARE\Classes\Directory\Background\shell\BatchFolderCreator\command" "" "$\"$INSTDIR\BatchFolderCreator.exe$\" $\"%V$\""
	WriteUninstaller $INSTDIR\uninstaller.exe
	createDirectory "$SMPROGRAMS\KoleSoft\Batch Folder Creator\"
	createShortcut	"$SMPROGRAMS\KoleSoft\Batch Folder Creator\Uninstall Batch Folder Creator.lnk" "$INSTDIR\uninstaller.exe"
SectionEnd

LangString DESC_SecDummy ${LANG_ENGLISH} "A test section."
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
!insertmacro MUI_DESCRIPTION_TEXT ${SecDummy} $(DESC_SecDummy)
!insertmacro MUI_FUNCTION_DESCRIPTION_END

Section "Uninstall"
	Delete "$SMPROGRAMS\KoleSoft\Batch Folder Creator\Uninstall Batch Folder Creator.lnk"
	RMDir "$SMPROGRAMS\KoleSoft\Batch Folder Creator"
	RMDir "$SMPROGRAMS\KoleSoft"
	Delete $INSTDIR\uninstaller.exe
	Delete $INSTDIR\BatchFolderCreator.exe
	Delete $INSTDIR\BatchFolderCreator.exe.config
	DeleteRegKey HKCU "SOFTWARE\Classes\Directory\Background\shell\BatchFolderCreator"
	RMDir "$INSTDIR"
SectionEnd