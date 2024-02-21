using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdanUI.Domain
{
    /*
     * Usage: Code Behind: FontIconKind.Wifi.GetDescription
     *        xaml: <.content>
     *              <FontIcon FontFamily="Sego MDL2 Assets" Glyph={Binding ..}" /> </content>
     * 
     * 
     * */ 
    public enum FontIconKind
    {
        [Description("\uE700")]
        GlobalNavButton,

        [Description("\uE701")]
        Wifi,

        [Description("\uE702")]
        Bluetooth,

        [Description("\uE703")]
        Connect,

        [Description("\uE704")]
        InternetSharing,

        [Description("\uE705")]
        VPN,

        [Description("\uE706")]
        Brightness,

        [Description("\uE707")]
        MapPin,

        [Description("\uE708")]
        QuietHours,

        [Description("\uE709")]
        Airplane,

        [Description("\uE70A")]
        Tablet,

        [Description("\uE70B")]
        QuickNote,

        [Description("\uE70C")]
        RememberedDevice,

        [Description("\uE70D")]
        ChevronDown,

        [Description("\uE70E")]
        ChevronUp,

        [Description("\uE70F")]
        Edit,

        [Description("\uE710")]
        Add,

        [Description("\uE711")]
        Cancel,

        [Description("\uE712")]
        More,

        [Description("\uE713")]
        Settings,

        [Description("\uE714")]
        Video,

        [Description("\uE715")]
        Mail,

        [Description("\uE716")]
        People,

        [Description("\uE717")]
        Phone,

        [Description("\uE718")]
        Pin,

        [Description("\uE719")]
        Shop,

        [Description("\uE71A")]
        Stop,

        [Description("\uE71B")]
        Link,

        [Description("\uE71C")]
        Filter,

        [Description("\uE71D")]
        AllApps,

        [Description("\uE71E")]
        Zoom,

        [Description("\uE71F")]
        ZoomOut,

        [Description("\uE720")]
        Microphone,

        [Description("\uE721")]
        Search,

        [Description("\uE722")]
        Camera,

        [Description("\uE723")]
        Attach,

        [Description("\uE724")]
        Send,

        [Description("\uE725")]
        SendFill,

        [Description("\uE726")]
        WalkSolid,

        [Description("\uE727")]
        InPrivate,

        [Description("\uE728")]
        FavoriteList,

        [Description("\uE729")]
        PageSolid,

        [Description("\uE72A")]
        Forward,

        [Description("\uE72B")]
        Back,

        [Description("\uE72C")]
        Refresh,

        [Description("\uE72D")]
        Share,

        [Description("\uE72E")]
        Lock,

        [Description("\uE730")]
        ReportHacked,

        [Description("\uE731")]
        EMI,

        [Description("\uE734")]
        FavoriteStar,

        [Description("\uE735")]
        FavoriteStarFill,

        [Description("\uE736")]
        ReadingMode,

        [Description("\uE737")]
        Favicon,

        [Description("\uE738")]
        Remove,

        [Description("\uE739")]
        Checkbox,

        [Description("\uE73A")]
        CheckboxComposite,

        [Description("\uE73B")]
        CheckboxFill,

        [Description("\uE73C")]
        CheckboxIndeterminate,

        [Description("\uE73D")]
        CheckboxCompositeReversed,

        [Description("\uE73E")]
        CheckMark,

        [Description("\uE73F")]
        BackToWindow,

        [Description("\uE740")]
        FullScreen,

        [Description("\uE741")]
        ResizeTouchLarger,

        [Description("\uE742")]
        ResizeTouchSmaller,

        [Description("\uE743")]
        ResizeMouseSmall,

        [Description("\uE744")]
        ResizeMouseMedium,

        [Description("\uE745")]
        ResizeMouseWide,

        [Description("\uE746")]
        ResizeMouseTall,

        [Description("\uE747")]
        ResizeMouseLarge,

        [Description("\uE748")]
        SwitchUser,

        [Description("\uE749")]
        Print,

        [Description("\uE74A")]
        Up,

        [Description("\uE74B")]
        Down,

        [Description("\uE74C")]
        OEM,

        [Description("\uE74D")]
        Delete,

        [Description("\uE74E")]
        Save,

        [Description("\uE74F")]
        Mute,

        [Description("\uE750")]
        BackSpaceQWERTY,

        [Description("\uE751")]
        ReturnKey,

        [Description("\uE752")]
        UpArrowShiftKey,

        [Description("\uE753")]
        Cloud,

        [Description("\uE754")]
        Flashlight,

        [Description("\uE755")]
        RotationLock,

        [Description("\uE756")]
        CommandPrompt,

        [Description("\uE759")]
        SIPMove,

        [Description("\uE75A")]
        SIPUndock,

        [Description("\uE75B")]
        SIPRedock,

        [Description("\uE75C")]
        EraseTool,

        [Description("\uE75D")]
        UnderscoreSpace,

        [Description("\uE75E")]
        GripperTool,

        [Description("\uE75F")]
        Dialpad,

        [Description("\uE760")]
        PageLeft,

        [Description("\uE761")]
        PageRight,

        [Description("\uE762")]
        MultiSelect,

        [Description("\uE763")]
        KeyboardLeftHanded,

        [Description("\uE764")]
        KeyboardRightHanded,

        [Description("\uE765")]
        KeyboardClassic,

        [Description("\uE766")]
        KeyboardSplit,

        [Description("\uE767")]
        Volume,

        [Description("\uE768")]
        Play,

        [Description("\uE769")]
        Pause,

        [Description("\uE76B")]
        ChevronLeft,

        [Description("\uE76C")]
        ChevronRight,

        [Description("\uE76D")]
        InkingTool,

        [Description("\uE76E")]
        Emoji2,

        [Description("\uE76F")]
        GripperBarHorizontal,

        [Description("\uE770")]
        System,

        [Description("\uE771")]
        Personalize,

        [Description("\uE772")]
        Devices,

        [Description("\uE773")]
        SearchAndApps,

        [Description("\uE774")]
        Globe,

        [Description("\uE775")]
        TimeLanguage,

        [Description("\uE776")]
        EaseOfAccess,

        [Description("\uE777")]
        UpdateRestore,

        [Description("\uE778")]
        HangUp,

        [Description("\uE779")]
        ContactInfo,

        [Description("\uE77A")]
        Unpin,

        [Description("\uE77B")]
        Contact,

        [Description("\uE77C")]
        Memo,

        [Description("\uE77E")]
        IncomingCall,

        [Description("\uE77F")]
        Paste,

        [Description("\uE780")]
        PhoneBook,

        [Description("\uE781")]
        LEDLight,

        [Description("\uE783")]
        Error,

        [Description("\uE784")]
        GripperBarVertical,

        [Description("\uE785")]
        Unlock,

        [Description("\uE786")]
        Slideshow,

        [Description("\uE787")]
        Calendar,

        [Description("\uE788")]
        GripperResize,

        [Description("\uE789")]
        Megaphone,

        [Description("\uE78A")]
        Trim,

        [Description("\uE78B")]
        NewWindow,

        [Description("\uE78C")]
        SaveLocal,

        [Description("\uE790")]
        Color,

        [Description("\uE791")]
        DataSense,

        [Description("\uE792")]
        SaveAs,

        [Description("\uE793")]
        Light,

        [Description("\uE799")]
        AspectRatio,

        [Description("\uE7A5")]
        DataSenseBar,

        [Description("\uE7A6")]
        Redo,

        [Description("\uE7A7")]
        Undo,

        [Description("\uE7A8")]
        Crop,

        [Description("\uE7AC")]
        OpenWith,

        [Description("\uE7AD")]
        Rotate,

        [Description("\uE7B3")]
        RedEye,

        [Description("\uE7B5")]
        SetlockScreen,

        [Description("\uE7B7")]
        MapPin2,

        [Description("\uE7B8")]
        Package,

        [Description("\uE7BA")]
        Warning,

        [Description("\uE7BC")]
        ReadingList,

        [Description("\uE7BE")]
        Education,

        [Description("\uE7BF")]
        ShoppingCart,

        [Description("\uE7C0")]
        Train,

        [Description("\uE7C1")]
        Flag,

        [Description("\uE7C2")]
        Move,

        [Description("\uE7C3")]
        Page,

        [Description("\uE7C4")]
        TaskView,

        [Description("\uE7C5")]
        BrowsePhotos,

        [Description("\uE7C6")]
        HalfStarLeft,

        [Description("\uE7C7")]
        HalfStarRight,

        [Description("\uE7C8")]
        Record,

        [Description("\uE7C9")]
        TouchPointer,

        [Description("\uE7DE")]
        LangJPN,

        [Description("\uE7E3")]
        Ferry,

        [Description("\uE7E6")]
        Highlight,

        [Description("\uE7E7")]
        ActionCenterNotification,

        [Description("\uE7E8")]
        PowerButton,

        [Description("\uE7EA")]
        ResizeTouchNarrower,

        [Description("\uE7EB")]
        ResizeTouchShorter,

        [Description("\uE7EC")]
        DrivingMode,

        [Description("\uE7ED")]
        RingerSilent,

        [Description("\uE7EE")]
        OtherUser,

        [Description("\uE7EF")]
        Admin,

        [Description("\uE7F0")]
        CC,

        [Description("\uE7F1")]
        SDCard,

        [Description("\uE7F2")]
        CallForwarding,

        [Description("\uE7F3")]
        SettingsDisplaySound,

        [Description("\uE7F4")]
        TVMonitor,

        [Description("\uE7F5")]
        Speakers,

        [Description("\uE7F6")]
        Headphone,

        [Description("\uE7F7")]
        DeviceLaptopPic,

        [Description("\uE7F8")]
        DeviceLaptopNoPic,

        [Description("\uE7F9")]
        DeviceMonitorRightPic,

        [Description("\uE7FA")]
        DeviceMonitorLeftPic,

        [Description("\uE7FB")]
        DeviceMonitorNoPic,

        [Description("\uE7FC")]
        Game,

        [Description("\uE7FD")]
        HorizontalTabKey,

        [Description("\uE802")]
        StreetsideSplitMinimize,

        [Description("\uE803")]
        StreetsideSplitExpand,

        [Description("\uE804")]
        Car,

        [Description("\uE805")]
        Walk,

        [Description("\uE806")]
        Bus,

        [Description("\uE809")]
        TiltUp,

        [Description("\uE80A")]
        TiltDown,

        [Description("\uE80B")]
        CallControl,

        [Description("\uE80C")]
        RotateMapRight,

        [Description("\uE80D")]
        RotateMapLeft,

        [Description("\uE80F")]
        Home,

        [Description("\uE811")]
        ParkingLocation,

        [Description("\uE812")]
        MapCompassTop,

        [Description("\uE813")]
        MapCompassBottom,

        [Description("\uE814")]
        IncidentTriangle,

        [Description("\uE815")]
        Touch,

        [Description("\uE816")]
        MapDirections,

        [Description("\uE819")]
        StartPoint,

        [Description("\uE81A")]
        StopPoint,

        [Description("\uE81B")]
        EndPoint,

        [Description("\uE81C")]
        History,

        [Description("\uE81D")]
        Location,

        [Description("\uE81E")]
        MapLayers,

        [Description("\uE81F")]
        Accident,

        [Description("\uE821")]
        Work,

        [Description("\uE822")]
        Construction,

        [Description("\uE823")]
        Recent,

        [Description("\uE825")]
        Bank,

        [Description("\uE826")]
        DownloadMap,

        [Description("\uE829")]
        InkingToolFill2,

        [Description("\uE82A")]
        HighlightFill2,

        [Description("\uE82B")]
        EraseToolFill,

        [Description("\uE82C")]
        EraseToolFill2,

        [Description("\uE82D")]
        Dictionary,

        [Description("\uE82E")]
        DictionaryAdd,

        [Description("\uE82F")]
        ToolTip,

        [Description("\uE830")]
        ChromeBack,

        [Description("\uE835")]
        ProvisioningPackage,

        [Description("\uE836")]
        AddRemoteDevice,

        [Description("\uE838")]
        FolderOpen,

        [Description("\uE839")]
        Ethernet,

        [Description("\uE83A")]
        ShareBroadband,

        [Description("\uE83B")]
        DirectAccess,

        [Description("\uE83C")]
        DialUp,

        [Description("\uE83D")]
        DefenderApp,

        [Description("\uE83E")]
        BatteryCharging9,

        [Description("\uE83F")]
        Battery10,

        [Description("\uE840")]
        Pinned,

        [Description("\uE841")]
        PinFill,

        [Description("\uE842")]
        PinnedFill,

        [Description("\uE843")]
        PeriodKey,

        [Description("\uE844")]
        PuncKey,

        [Description("\uE845")]
        RevToggleKey,

        [Description("\uE846")]
        RightArrowKeyTime1,

        [Description("\uE847")]
        RightArrowKeyTime2,

        [Description("\uE848")]
        LeftQuote,

        [Description("\uE849")]
        RightQuote,

        [Description("\uE84A")]
        DownShiftKey,

        [Description("\uE84B")]
        UpShiftKey,

        [Description("\uE84C")]
        PuncKey0,

        [Description("\uE84D")]
        PuncKeyLeftBottom,

        [Description("\uE84E")]
        RightArrowKeyTime3,

        [Description("\uE84F")]
        RightArrowKeyTime4,

        [Description("\uE850")]
        Battery0,

        [Description("\uE851")]
        Battery1,

        [Description("\uE852")]
        Battery2,

        [Description("\uE853")]
        Battery3,

        [Description("\uE854")]
        Battery4,

        [Description("\uE855")]
        Battery5,

        [Description("\uE856")]
        Battery6,

        [Description("\uE857")]
        Battery7,

        [Description("\uE858")]
        Battery8,

        [Description("\uE859")]
        Battery9,

        [Description("\uE85A")]
        BatteryCharging0,

        [Description("\uE85B")]
        BatteryCharging1,

        [Description("\uE85C")]
        BatteryCharging2,

        [Description("\uE85D")]
        BatteryCharging3,

        [Description("\uE85E")]
        BatteryCharging4,

        [Description("\uE85F")]
        BatteryCharging5,

        [Description("\uE860")]
        BatteryCharging6,

        [Description("\uE861")]
        BatteryCharging7,

        [Description("\uE862")]
        BatteryCharging8,

        [Description("\uE863")]
        BatterySaver0,

        [Description("\uE864")]
        BatterySaver1,

        [Description("\uE865")]
        BatterySaver2,

        [Description("\uE866")]
        BatterySaver3,

        [Description("\uE867")]
        BatterySaver4,

        [Description("\uE868")]
        BatterySaver5,

        [Description("\uE869")]
        BatterySaver6,

        [Description("\uE86A")]
        BatterySaver7,

        [Description("\uE86B")]
        BatterySaver8,

        [Description("\uE86C")]
        SignalBars1,

        [Description("\uE86D")]
        SignalBars2,

        [Description("\uE86E")]
        SignalBars3,

        [Description("\uE86F")]
        SignalBars4,

        [Description("\uE870")]
        SignalBars5,

        [Description("\uE871")]
        SignalNotConnected,

        [Description("\uE872")]
        Wifi1,

        [Description("\uE873")]
        Wifi2,

        [Description("\uE874")]
        Wifi3,

        [Description("\uE875")]
        MobSIMLock,

        [Description("\uE876")]
        MobSIMMissing,

        [Description("\uE877")]
        Vibrate,

        [Description("\uE878")]
        RoamingInternational,

        [Description("\uE879")]
        RoamingDomestic,

        [Description("\uE87A")]
        CallForwardInternational,

        [Description("\uE87B")]
        CallForwardRoaming,

        [Description("\uE87C")]
        JpnRomanji,

        [Description("\uE87D")]
        JpnRomanjiLock,

        [Description("\uE87E")]
        JpnRomanjiShift,

        [Description("\uE87F")]
        JpnRomanjiShiftLock,

        [Description("\uE880")]
        StatusDataTransfer,

        [Description("\uE881")]
        StatusDataTransferVPN,

        [Description("\uE882")]
        StatusDualSIM2,

        [Description("\uE883")]
        StatusDualSIM2VPN,

        [Description("\uE884")]
        StatusDualSIM1,

        [Description("\uE885")]
        StatusDualSIM1VPN,

        [Description("\uE886")]
        StatusSGLTE,

        [Description("\uE887")]
        StatusSGLTECell,

        [Description("\uE888")]
        StatusSGLTEDataVPN,

        [Description("\uE889")]
        StatusVPN,

        [Description("\uE88A")]
        WifiHotspot,

        [Description("\uE88B")]
        LanguageKor,

        [Description("\uE88C")]
        LanguageCht,

        [Description("\uE88D")]
        LanguageChs,

        [Description("\uE88E")]
        USB,

        [Description("\uE88F")]
        InkingToolFill,

        [Description("\uE890")]
        View,

        [Description("\uE891")]
        HighlightFill,

        [Description("\uE892")]
        Previous,

        [Description("\uE893")]
        Next,

        [Description("\uE894")]
        Clear,

        [Description("\uE895")]
        Sync,

        [Description("\uE896")]
        Download,

        [Description("\uE897")]
        Help,

        [Description("\uE898")]
        Upload,

        [Description("\uE899")]
        Emoji,

        [Description("\uE89A")]
        TwoPage,

        [Description("\uE89B")]
        LeaveChat,

        [Description("\uE89C")]
        MailForward,

        [Description("\uE89E")]
        RotateCamera,

        [Description("\uE89F")]
        ClosePane,

        [Description("\uE8A0")]
        OpenPane,

        [Description("\uE8A1")]
        PreviewLink,

        [Description("\uE8A2")]
        AttachCamera,

        [Description("\uE8A3")]
        ZoomIn,

        [Description("\uE8A4")]
        Bookmarks,

        [Description("\uE8A5")]
        Document,

        [Description("\uE8A6")]
        ProtectedDocument,

        [Description("\uE8A7")]
        OpenInNewWindow,

        [Description("\uE8A8")]
        MailFill,

        [Description("\uE8A9")]
        ViewAll,

        [Description("\uE8AA")]
        VideoChat,

        [Description("\uE8AB")]
        Switch,

        [Description("\uE8AC")]
        Rename,

        [Description("\uE8AD")]
        Go,

        [Description("\uE8AE")]
        SurfaceHub,

        [Description("\uE8AF")]
        Remote,

        [Description("\uE8B0")]
        Click,

        [Description("\uE8B1")]
        Shuffle,

        [Description("\uE8B2")]
        Movies,

        [Description("\uE8B3")]
        SelectAll,

        [Description("\uE8B4")]
        Orientation,

        [Description("\uE8B5")]
        Import,

        [Description("\uE8B6")]
        ImportAll,

        [Description("\uE8B7")]
        Folder,

        [Description("\uE8B8")]
        Webcam,

        [Description("\uE8B9")]
        Picture,

        [Description("\uE8BA")]
        Caption,

        [Description("\uE8BB")]
        ChromeClose,

        [Description("\uE8BC")]
        ShowResults,

        [Description("\uE8BD")]
        Message,

        [Description("\uE8BE")]
        Leaf,

        [Description("\uE8BF")]
        CalendarDay,

        [Description("\uE8C0")]
        CalendarWeek,

        [Description("\uE8C1")]
        Characters,

        [Description("\uE8C2")]
        MailReplyAll,

        [Description("\uE8C3")]
        Read,

        [Description("\uE8C4")]
        ShowBcc,

        [Description("\uE8C5")]
        HideBcc,

        [Description("\uE8C6")]
        Cut,

        [Description("\uE8C7")]
        PaymentCard,

        [Description("\uE8C8")]
        Copy,

        [Description("\uE8C9")]
        Important,

        [Description("\uE8CA")]
        MailReply,

        [Description("\uE8CB")]
        Sort,

        [Description("\uE8CC")]
        MobileTablet,

        [Description("\uE8CD")]
        DisconnectDrive,

        [Description("\uE8CE")]
        MapDrive,

        [Description("\uE8CF")]
        ContactPresence,

        [Description("\uE8D0")]
        Priority,

        [Description("\uE8D1")]
        GotoToday,

        [Description("\uE8D2")]
        Font,

        [Description("\uE8D3")]
        FontColor,

        [Description("\uE8D4")]
        Contact2,

        [Description("\uE8D5")]
        FolderFill,

        [Description("\uE8D6")]
        Audio,

        [Description("\uE8D7")]
        Permissions,

        [Description("\uE8D8")]
        DisableUpdates,

        [Description("\uE8D9")]
        Unfavorite,

        [Description("\uE8DA")]
        OpenLocal,

        [Description("\uE8DB")]
        Italic,

        [Description("\uE8DC")]
        Underline,

        [Description("\uE8DD")]
        Bold,

        [Description("\uE8DE")]
        MoveToFolder,

        [Description("\uE8DF")]
        LikeDislike,

        [Description("\uE8E0")]
        Dislike,

        [Description("\uE8E1")]
        Like,

        [Description("\uE8E2")]
        AlignRight,

        [Description("\uE8E3")]
        AlignCenter,

        [Description("\uE8E4")]
        AlignLeft,

        [Description("\uE8E5")]
        OpenFile,

        [Description("\uE8E6")]
        ClearSelection,

        [Description("\uE8E7")]
        FontDecrease,

        [Description("\uE8E8")]
        FontIncrease,

        [Description("\uE8E9")]
        FontSize,

        [Description("\uE8EA")]
        CellPhone,

        [Description("\uE8EB")]
        Reshare,

        [Description("\uE8EC")]
        Tag,

        [Description("\uE8ED")]
        RepeatOne,

        [Description("\uE8EE")]
        RepeatAll,

        [Description("\uE8EF")]
        Calculator,

        [Description("\uE8F0")]
        Directions,

        [Description("\uE8F1")]
        Library,

        [Description("\uE8F2")]
        ChatBubbles,

        [Description("\uE8F3")]
        PostUpdate,

        [Description("\uE8F4")]
        NewFolder,

        [Description("\uE8F5")]
        CalendarReply,

        [Description("\uE8F6")]
        UnsyncFolder,

        [Description("\uE8F7")]
        SyncFolder,

        [Description("\uE8F8")]
        BlockContact,

        [Description("\uE8F9")]
        SwitchApps,

        [Description("\uE8FA")]
        AddFriend,

        [Description("\uE8FB")]
        Accept,

        [Description("\uE8FC")]
        GoToStart,

        [Description("\uE8FD")]
        BulletedList,

        [Description("\uE8FE")]
        Scan,

        [Description("\uE8FF")]
        Preview,

        [Description("\uE902")]
        Group,

        [Description("\uE904")]
        ZeroBars,

        [Description("\uE905")]
        OneBar,

        [Description("\uE906")]
        TwoBars,

        [Description("\uE907")]
        ThreeBars,

        [Description("\uE908")]
        FourBars,

        [Description("\uE909")]
        World,

        [Description("\uE90A")]
        Comment,

        [Description("\uE90B")]
        MusicInfo,

        [Description("\uE90C")]
        DockLeft,

        [Description("\uE90D")]
        DockRight,

        [Description("\uE90E")]
        DockBottom,

        [Description("\uE90F")]
        Repair,

        [Description("\uE910")]
        Accounts,

        [Description("\uE911")]
        DullSound,

        [Description("\uE912")]
        Manage,

        [Description("\uE913")]
        Street,

        [Description("\uE914")]
        Printer3D,

        [Description("\uE915")]
        RadioBullet,

        [Description("\uE916")]
        Stopwatch,

        [Description("\uE91B")]
        Photo,

        [Description("\uE91C")]
        ActionCenter,

        [Description("\uE91F")]
        FullCircleMask,

        [Description("\uE921")]
        ChromeMinimize,

        [Description("\uE922")]
        ChromeMaximize,

        [Description("\uE923")]
        ChromeRestore,

        [Description("\uE924")]
        Annotation,

        [Description("\uE925")]
        BackSpaceQWERTYSm,

        [Description("\uE926")]
        BackSpaceQWERTYMd,

        [Description("\uE927")]
        Swipe,

        [Description("\uE928")]
        Fingerprint,

        [Description("\uE929")]
        Handwriting,

        [Description("\uE92C")]
        ChromeBackToWindow,

        [Description("\uE92D")]
        ChromeFullScreen,

        [Description("\uE92E")]
        KeyboardStandard,

        [Description("\uE92F")]
        KeyboardDismiss,

        [Description("\uE930")]
        Completed,

        [Description("\uE931")]
        ChromeAnnotate,

        [Description("\uE932")]
        Label,

        [Description("\uE933")]
        IBeam,

        [Description("\uE934")]
        IBeamOutline,

        [Description("\uE935")]
        FlickDown,

        [Description("\uE936")]
        FlickUp,

        [Description("\uE937")]
        FlickLeft,

        [Description("\uE938")]
        FlickRight,

        [Description("\uE939")]
        FeedbackApp,

        [Description("\uE93C")]
        MusicAlbum,

        [Description("\uE93E")]
        Streaming,

        [Description("\uE943")]
        Code,

        [Description("\uE944")]
        ReturnToWindow,

        [Description("\uE945")]
        LightningBolt,

        [Description("\uE946")]
        Info,

        [Description("\uE947")]
        CalculatorMultiply,

        [Description("\uE948")]
        CalculatorAddition,

        [Description("\uE949")]
        CalculatorSubtract,

        [Description("\uE94A")]
        CalculatorDivide,

        [Description("\uE94B")]
        CalculatorSquareroot,

        [Description("\uE94C")]
        CalculatorPercentage,

        [Description("\uE94D")]
        CalculatorNegate,

        [Description("\uE94E")]
        CalculatorEqualTo,

        [Description("\uE94F")]
        CalculatorBackspace,

        [Description("\uE950")]
        Component,

        [Description("\uE951")]
        DMC,

        [Description("\uE952")]
        Dock,

        [Description("\uE953")]
        MultimediaDMS,

        [Description("\uE954")]
        MultimediaDVR,

        [Description("\uE955")]
        MultimediaPMP,

        [Description("\uE956")]
        PrintfaxPrinterFile,

        [Description("\uE957")]
        Sensor,

        [Description("\uE958")]
        StorageOptical,

        [Description("\uE95A")]
        Communications,

        [Description("\uE95B")]
        Headset,

        [Description("\uE95D")]
        Projector,

        [Description("\uE95E")]
        Health,

        [Description("\uE95F")]
        Wire,

        [Description("\uE960")]
        Webcam2,

        [Description("\uE961")]
        Input,

        [Description("\uE962")]
        Mouse,

        [Description("\uE963")]
        Smartcard,

        [Description("\uE964")]
        SmartcardVirtual,

        [Description("\uE965")]
        MediaStorageTower,

        [Description("\uE966")]
        ReturnKeySm,

        [Description("\uE967")]
        GameConsole,

        [Description("\uE968")]
        Network,

        [Description("\uE969")]
        StorageNetworkWireless,

        [Description("\uE96A")]
        StorageTape,

        [Description("\uE96D")]
        ChevronUpSmall,

        [Description("\uE96E")]
        ChevronDownSmall,

        [Description("\uE96F")]
        ChevronLeftSmall,

        [Description("\uE970")]
        ChevronRightSmall,

        [Description("\uE971")]
        ChevronUpMed,

        [Description("\uE972")]
        ChevronDownMed,

        [Description("\uE973")]
        ChevronLeftMed,

        [Description("\uE974")]
        ChevronRightMed,

        [Description("\uE975")]
        Devices2,

        [Description("\uE976")]
        ExpandTile,

        [Description("\uE977")]
        PC1,

        [Description("\uE978")]
        PresenceChicklet,

        [Description("\uE979")]
        PresenceChickletVideo,

        [Description("\uE97A")]
        Reply,

        [Description("\uE97B")]
        SetTile,

        [Description("\uE97C")]
        Type,

        [Description("\uE97D")]
        Korean,

        [Description("\uE97E")]
        HalfAlpha,

        [Description("\uE97F")]
        FullAlpha,

        [Description("\uE980")]
        Key12On,

        [Description("\uE981")]
        ChineseChangjie,

        [Description("\uE982")]
        QWERTYOn,

        [Description("\uE983")]
        QWERTYOff,

        [Description("\uE984")]
        ChineseQuick,

        [Description("\uE985")]
        Japanese,

        [Description("\uE986")]
        FullHiragana,

        [Description("\uE987")]
        FullKatakana,

        [Description("\uE988")]
        HalfKatakana,

        [Description("\uE989")]
        ChineseBoPoMoFo,

        [Description("\uE98A")]
        ChinesePinyin,

        [Description("\uE98F")]
        ConstructionCone,

        [Description("\uE990")]
        XboxOneConsole,

        [Description("\uE992")]
        Volume0,

        [Description("\uE993")]
        Volume1,

        [Description("\uE994")]
        Volume2,

        [Description("\uE995")]
        Volume3,

        [Description("\uE996")]
        BatteryUnknown,

        [Description("\uE998")]
        WifiAttentionOverlay,

        [Description("\uE99A")]
        Robot,

        [Description("\uE9A1")]
        TapAndSend,

        [Description("\uE9A6")]
        FitPage,

        [Description("\uE9A8")]
        PasswordKeyShow,

        [Description("\uE9A9")]
        PasswordKeyHide,

        [Description("\uE9AA")]
        BidiLtr,

        [Description("\uE9AB")]
        BidiRtl,

        [Description("\uE9AC")]
        ForwardSm,

        [Description("\uE9AD")]
        CommaKey,

        [Description("\uE9AE")]
        DashKey,

        [Description("\uE9AF")]
        DullSoundKey,

        [Description("\uE9B0")]
        HalfDullSound,

        [Description("\uE9B1")]
        RightDoubleQuote,

        [Description("\uE9B2")]
        LeftDoubleQuote,

        [Description("\uE9B3")]
        PuncKeyRightBottom,

        [Description("\uE9B4")]
        PuncKey1,

        [Description("\uE9B5")]
        PuncKey2,

        [Description("\uE9B6")]
        PuncKey3,

        [Description("\uE9B7")]
        PuncKey4,

        [Description("\uE9B8")]
        PuncKey5,

        [Description("\uE9B9")]
        PuncKey6,

        [Description("\uE9BA")]
        PuncKey9,

        [Description("\uE9BB")]
        PuncKey7,

        [Description("\uE9BC")]
        PuncKey8,

        [Description("\uE9CA")]
        Frigid,

        [Description("\uE9CE")]
        Unknown,

        [Description("\uE9D2")]
        AreaChart,

        [Description("\uE9D5")]
        CheckList,

        [Description("\uE9D9")]
        Diagnostic,

        [Description("\uE9E9")]
        Equalizer,

        [Description("\uE9F3")]
        Process,

        [Description("\uE9F5")]
        Processing,

        [Description("\uE9F9")]
        ReportDocument,

        [Description("\uEA0C")]
        VideoSolid,

        [Description("\uEA0D")]
        MixedMediaBadge,

        [Description("\uEA14")]
        DisconnectDisplay,

        [Description("\uEA18")]
        Shield,

        [Description("\uEA1F")]
        Info2,

        [Description("\uEA21")]
        ActionCenterAsterisk,

        [Description("\uEA24")]
        Beta,

        [Description("\uEA35")]
        SaveCopy,

        [Description("\uEA37")]
        List,

        [Description("\uEA38")]
        Asterisk,

        [Description("\uEA39")]
        ErrorBadge,

        [Description("\uEA3A")]
        CircleRing,

        [Description("\uEA3B")]
        CircleFill,

        [Description("\uEA3C")]
        MergeCall,

        [Description("\uEA3D")]
        PrivateCall,

        [Description("\uEA3F")]
        Record2,

        [Description("\uEA40")]
        AllAppsMirrored,

        [Description("\uEA41")]
        BookmarksMirrored,

        [Description("\uEA42")]
        BulletedListMirrored,

        [Description("\uEA43")]
        CallForwardInternationalMirrored,

        [Description("\uEA44")]
        CallForwardRoamingMirrored,

        [Description("\uEA47")]
        ChromeBackMirrored,

        [Description("\uEA48")]
        ClearSelectionMirrored,

        [Description("\uEA49")]
        ClosePaneMirrored,

        [Description("\uEA4A")]
        ContactInfoMirrored,

        [Description("\uEA4B")]
        DockRightMirrored,

        [Description("\uEA4C")]
        DockLeftMirrored,

        [Description("\uEA4E")]
        ExpandTileMirrored,

        [Description("\uEA4F")]
        GoMirrored,

        [Description("\uEA50")]
        GripperResizeMirrored,

        [Description("\uEA51")]
        HelpMirrored,

        [Description("\uEA52")]
        ImportMirrored,

        [Description("\uEA53")]
        ImportAllMirrored,

        [Description("\uEA54")]
        LeaveChatMirrored,

        [Description("\uEA55")]
        ListMirrored,

        [Description("\uEA56")]
        MailForwardMirrored,

        [Description("\uEA57")]
        MailReplyMirrored,

        [Description("\uEA58")]
        MailReplyAllMirrored,

        [Description("\uEA5B")]
        OpenPaneMirrored,

        [Description("\uEA5C")]
        OpenWithMirrored,

        [Description("\uEA5E")]
        ParkingLocationMirrored,

        [Description("\uEA5F")]
        ResizeMouseMediumMirrored,

        [Description("\uEA60")]
        ResizeMouseSmallMirrored,

        [Description("\uEA61")]
        ResizeMouseTallMirrored,

        [Description("\uEA62")]
        ResizeTouchNarrowerMirrored,

        [Description("\uEA63")]
        SendMirrored,

        [Description("\uEA64")]
        SendFillMirrored,

        [Description("\uEA65")]
        ShowResultsMirrored,

        [Description("\uEA69")]
        Media,

        [Description("\uEA6A")]
        SyncError,

        [Description("\uEA6C")]
        Devices3,

        [Description("\uEA79")]
        SlowMotionOn,

        [Description("\uEA80")]
        Lightbulb,

        [Description("\uEA81")]
        StatusCircle,

        [Description("\uEA82")]
        StatusTriangle,

        [Description("\uEA83")]
        StatusError,

        [Description("\uEA84")]
        StatusWarning,

        [Description("\uEA86")]
        Puzzle,

        [Description("\uEA89")]
        CalendarSolid,

        [Description("\uEA8A")]
        HomeSolid,

        [Description("\uEA8B")]
        ParkingLocationSolid,

        [Description("\uEA8C")]
        ContactSolid,

        [Description("\uEA8D")]
        ConstructionSolid,

        [Description("\uEA8E")]
        AccidentSolid,

        [Description("\uEA8F")]
        Ringer,

        [Description("\uEA90")]
        PDF,

        [Description("\uEA91")]
        ThoughtBubble,

        [Description("\uEA92")]
        HeartBroken,

        [Description("\uEA93")]
        BatteryCharging10,

        [Description("\uEA94")]
        BatterySaver9,

        [Description("\uEA95")]
        BatterySaver10,

        [Description("\uEA97")]
        CallForwardingMirrored,

        [Description("\uEA98")]
        MultiSelectMirrored,

        [Description("\uEA99")]
        Broom,

        [Description("\uEAC2")]
        ForwardCall,

        [Description("\uEADF")]
        Trackers,

        [Description("\uEAFC")]
        Market,

        [Description("\uEB05")]
        PieSingle,

        [Description("\uEB0F")]
        StockUp,

        [Description("\uEB11")]
        StockDown,

        [Description("\uEB3C")]
        Design,

        [Description("\uEB41")]
        Website,

        [Description("\uEB42")]
        Drop,

        [Description("\uEB44")]
        Radar,

        [Description("\uEB47")]
        BusSolid,

        [Description("\uEB48")]
        FerrySolid,

        [Description("\uEB49")]
        StartPointSolid,

        [Description("\uEB4A")]
        StopPointSolid,

        [Description("\uEB4B")]
        EndPointSolid,

        [Description("\uEB4C")]
        AirplaneSolid,

        [Description("\uEB4D")]
        TrainSolid,

        [Description("\uEB4E")]
        WorkSolid,

        [Description("\uEB4F")]
        ReminderFill,

        [Description("\uEB50")]
        Reminder,

        [Description("\uEB51")]
        Heart,

        [Description("\uEB52")]
        HeartFill,

        [Description("\uEB55")]
        EthernetError,

        [Description("\uEB56")]
        EthernetWarning,

        [Description("\uEB57")]
        StatusConnecting1,

        [Description("\uEB58")]
        StatusConnecting2,

        [Description("\uEB59")]
        StatusUnsecure,

        [Description("\uEB5A")]
        WifiError0,

        [Description("\uEB5B")]
        WifiError1,

        [Description("\uEB5C")]
        WifiError2,

        [Description("\uEB5D")]
        WifiError3,

        [Description("\uEB5E")]
        WifiError4,

        [Description("\uEB5F")]
        WifiWarning0,

        [Description("\uEB60")]
        WifiWarning1,

        [Description("\uEB61")]
        WifiWarning2,

        [Description("\uEB62")]
        WifiWarning3,

        [Description("\uEB63")]
        WifiWarning4,

        [Description("\uEB66")]
        Devices4,

        [Description("\uEB67")]
        NUIIris,

        [Description("\uEB68")]
        NUIFace,

        [Description("\uEB77")]
        GatewayRouter,

        [Description("\uEB7E")]
        EditMirrored,

        [Description("\uEB82")]
        NUIFPStartSlideHand,

        [Description("\uEB83")]
        NUIFPStartSlideAction,

        [Description("\uEB84")]
        NUIFPContinueSlideHand,

        [Description("\uEB85")]
        NUIFPContinueSlideAction,

        [Description("\uEB86")]
        NUIFPRollRightHand,

        [Description("\uEB87")]
        NUIFPRollRightHandAction,

        [Description("\uEB88")]
        NUIFPRollLeftHand,

        [Description("\uEB89")]
        NUIFPRollLeftAction,

        [Description("\uEB8A")]
        NUIFPPressHand,

        [Description("\uEB8B")]
        NUIFPPressAction,

        [Description("\uEB8C")]
        NUIFPPressRepeatHand,

        [Description("\uEB8D")]
        NUIFPPressRepeatAction,

        [Description("\uEB90")]
        StatusErrorFull,

        [Description("\uEB91")]
        TaskViewExpanded,

        [Description("\uEB95")]
        Certificate,

        [Description("\uEB96")]
        BackSpaceQWERTYLg,

        [Description("\uEB97")]
        ReturnKeyLg,

        [Description("\uEB9D")]
        FastForward,

        [Description("\uEB9E")]
        Rewind,

        [Description("\uEB9F")]
        Photo2,

        [Description("\uEBA0")]
        MobBattery0,

        [Description("\uEBA1")]
        MobBattery1,

        [Description("\uEBA2")]
        MobBattery2,

        [Description("\uEBA3")]
        MobBattery3,

        [Description("\uEBA4")]
        MobBattery4,

        [Description("\uEBA5")]
        MobBattery5,

        [Description("\uEBA6")]
        MobBattery6,

        [Description("\uEBA7")]
        MobBattery7,

        [Description("\uEBA8")]
        MobBattery8,

        [Description("\uEBA9")]
        MobBattery9,

        [Description("\uEBAA")]
        MobBattery10,

        [Description("\uEBAB")]
        MobBatteryCharging0,

        [Description("\uEBAC")]
        MobBatteryCharging1,

        [Description("\uEBAD")]
        MobBatteryCharging2,

        [Description("\uEBAE")]
        MobBatteryCharging3,

        [Description("\uEBAF")]
        MobBatteryCharging4,

        [Description("\uEBB0")]
        MobBatteryCharging5,

        [Description("\uEBB1")]
        MobBatteryCharging6,

        [Description("\uEBB2")]
        MobBatteryCharging7,

        [Description("\uEBB3")]
        MobBatteryCharging8,

        [Description("\uEBB4")]
        MobBatteryCharging9,

        [Description("\uEBB5")]
        MobBatteryCharging10,

        [Description("\uEBB6")]
        MobBatterySaver0,

        [Description("\uEBB7")]
        MobBatterySaver1,

        [Description("\uEBB8")]
        MobBatterySaver2,

        [Description("\uEBB9")]
        MobBatterySaver3,

        [Description("\uEBBA")]
        MobBatterySaver4,

        [Description("\uEBBB")]
        MobBatterySaver5,

        [Description("\uEBBC")]
        MobBatterySaver6,

        [Description("\uEBBD")]
        MobBatterySaver7,

        [Description("\uEBBE")]
        MobBatterySaver8,

        [Description("\uEBBF")]
        MobBatterySaver9,

        [Description("\uEBC0")]
        MobBatterySaver10,

        [Description("\uEBC3")]
        DictionaryCloud,

        [Description("\uEBC4")]
        ResetDrive,

        [Description("\uEBC5")]
        VolumeBars,

        [Description("\uEBC6")]
        Project,

        [Description("\uEBD2")]
        AdjustHologram,

        [Description("\uEBD3")]
        CloudDownload,

        [Description("\uEBD4")]
        MobWifiCallBars,

        [Description("\uEBD5")]
        MobWifiCall0,

        [Description("\uEBD6")]
        MobWifiCall1,

        [Description("\uEBD7")]
        MobWifiCall2,

        [Description("\uEBD8")]
        MobWifiCall3,

        [Description("\uEBD9")]
        MobWifiCall4,

        [Description("\uEBDA")]
        Family,

        [Description("\uEBDB")]
        LockFeedback,

        [Description("\uEBDE")]
        DeviceDiscovery,

        [Description("\uEBE6")]
        WindDirection,

        [Description("\uEBE7")]
        RightArrowKeyTime0,

        [Description("\uEBE8")]
        Bug,

        [Description("\uEBFC")]
        TabletMode,

        [Description("\uEBFD")]
        StatusCircleLeft,

        [Description("\uEBFE")]
        StatusTriangleLeft,

        [Description("\uEBFF")]
        StatusErrorLeft,

        [Description("\uEC00")]
        StatusWarningLeft,

        [Description("\uEC02")]
        MobBatteryUnknown,

        [Description("\uEC05")]
        NetworkTower,

        [Description("\uEC06")]
        CityNext,

        [Description("\uEC07")]
        CityNext2,

        [Description("\uEC08")]
        Courthouse,

        [Description("\uEC09")]
        Groceries,

        [Description("\uEC0A")]
        Sustainable,

        [Description("\uEC0B")]
        BuildingEnergy,

        [Description("\uEC11")]
        ToggleFilled,

        [Description("\uEC12")]
        ToggleBorder,

        [Description("\uEC13")]
        SliderThumb,

        [Description("\uEC14")]
        ToggleThumb,

        [Description("\uEC15")]
        MiracastLogoSmall,

        [Description("\uEC16")]
        MiracastLogoLarge,

        [Description("\uEC19")]
        PLAP,

        [Description("\uEC1B")]
        Badge,

        [Description("\uEC1E")]
        SignalRoaming,

        [Description("\uEC20")]
        MobileLocked,

        [Description("\uEC24")]
        InsiderHubApp,

        [Description("\uEC25")]
        PersonalFolder,

        [Description("\uEC26")]
        HomeGroup,

        [Description("\uEC27")]
        MyNetwork,

        [Description("\uEC31")]
        KeyboardFull,

        [Description("\uEC32")]
        Cafe,

        [Description("\uEC37")]
        MobSignal1,

        [Description("\uEC38")]
        MobSignal2,

        [Description("\uEC39")]
        MobSignal3,

        [Description("\uEC3A")]
        MobSignal4,

        [Description("\uEC3B")]
        MobSignal5,

        [Description("\uEC3C")]
        MobWifi1,

        [Description("\uEC3D")]
        MobWifi2,

        [Description("\uEC3E")]
        MobWifi3,

        [Description("\uEC3F")]
        MobWifi4,

        [Description("\uEC40")]
        MobAirplane,

        [Description("\uEC41")]
        MobBluetooth,

        [Description("\uEC42")]
        MobActionCenter,

        [Description("\uEC43")]
        MobLocation,

        [Description("\uEC44")]
        MobWifiHotspot,

        [Description("\uEC45")]
        LanguageJpn,

        [Description("\uEC46")]
        MobQuietHours,

        [Description("\uEC47")]
        MobDrivingMode,

        [Description("\uEC48")]
        SpeedOff,

        [Description("\uEC49")]
        SpeedMedium,

        [Description("\uEC4A")]
        SpeedHigh,

        [Description("\uEC4E")]
        ThisPC,

        [Description("\uEC4F")]
        MusicNote,

        [Description("\uEC50")]
        FileExplorer,

        [Description("\uEC51")]
        FileExplorerApp,

        [Description("\uEC52")]
        LeftArrowKeyTime0,

        [Description("\uEC54")]
        MicOff,

        [Description("\uEC55")]
        MicSleep,

        [Description("\uEC56")]
        MicError,

        [Description("\uEC57")]
        PlaybackRate1x,

        [Description("\uEC58")]
        PlaybackRateOther,

        [Description("\uEC59")]
        CashDrawer,

        [Description("\uEC5A")]
        BarcodeScanner,

        [Description("\uEC5B")]
        ReceiptPrinter,

        [Description("\uEC5C")]
        MagStripeReader,

        [Description("\uEC61")]
        CompletedSolid,

        [Description("\uEC64")]
        CompanionApp,

        [Description("\uEC6C")]
        Favicon2,

        [Description("\uEC6D")]
        SwipeRevealArt,

        [Description("\uEC71")]
        MicOn,

        [Description("\uEC72")]
        MicClipping,

        [Description("\uEC74")]
        TabletSelected,

        [Description("\uEC75")]
        MobileSelected,

        [Description("\uEC76")]
        LaptopSelected,

        [Description("\uEC77")]
        TVMonitorSelected,

        [Description("\uEC7A")]
        DeveloperTools,

        [Description("\uEC7E")]
        MobCallForwarding,

        [Description("\uEC7F")]
        MobCallForwardingMirrored,

        [Description("\uEC80")]
        BodyCam,

        [Description("\uEC81")]
        PoliceCar,

        [Description("\uEC87")]
        Draw,

        [Description("\uEC88")]
        DrawSolid,

        [Description("\uEC8A")]
        LowerBrightness,

        [Description("\uEC8F")]
        ScrollUpDown,

        [Description("\uEC92")]
        DateTime,

        [Description("\uEC94")]
        HoloLens,

        [Description("\uECA5")]
        Tiles,

        [Description("\uECA7")]
        PartyLeader,

        [Description("\uECAA")]
        AppIconDefault,

        [Description("\uECAD")]
        Calories,

        [Description("\uECAF")]
        POI,

        [Description("\uECB9")]
        BandBattery0,

        [Description("\uECBA")]
        BandBattery1,

        [Description("\uECBB")]
        BandBattery2,

        [Description("\uECBC")]
        BandBattery3,

        [Description("\uECBD")]
        BandBattery4,

        [Description("\uECBE")]
        BandBattery5,

        [Description("\uECBF")]
        BandBattery6,

        [Description("\uECC4")]
        AddSurfaceHub,

        [Description("\uECC5")]
        DevUpdate,

        [Description("\uECC6")]
        Unit,

        [Description("\uECC8")]
        AddTo,

        [Description("\uECC9")]
        RemoveFrom,

        [Description("\uECCA")]
        RadioBtnOff,

        [Description("\uECCB")]
        RadioBtnOn,

        [Description("\uECCC")]
        RadioBullet2,

        [Description("\uECCD")]
        ExploreContent,

        [Description("\uECE4")]
        Blocked2,

        [Description("\uECE7")]
        ScrollMode,

        [Description("\uECE8")]
        ZoomMode,

        [Description("\uECE9")]
        PanMode,

        [Description("\uECF0")]
        WiredUSB,

        [Description("\uECF1")]
        WirelessUSB,

        [Description("\uECF3")]
        USBSafeConnect,

        [Description("\uED0C")]
        ActionCenterNotificationMirrored,

        [Description("\uED0D")]
        ActionCenterMirrored,

        [Description("\uED0E")]
        SubscriptionAdd,

        [Description("\uED10")]
        ResetDevice,

        [Description("\uED11")]
        SubscriptionAddMirrored,

        [Description("\uED14")]
        QRCode,

        [Description("\uED15")]
        Feedback,

        [Description("\uED1A")]
        Hide,

        [Description("\uED1E")]
        Subtitles,

        [Description("\uED1F")]
        SubtitlesAudio,

        [Description("\uED25")]
        OpenFolderHorizontal,

        [Description("\uED28")]
        CalendarMirrored,

        [Description("\uED2A")]
        MobeSIM,

        [Description("\uED2B")]
        MobeSIMNoProfile,

        [Description("\uED2C")]
        MobeSIMLocked,

        [Description("\uED2D")]
        MobeSIMBusy,

        [Description("\uED2E")]
        SignalError,

        [Description("\uED2F")]
        StreamingEnterprise,

        [Description("\uED30")]
        Headphone0,

        [Description("\uED31")]
        Headphone1,

        [Description("\uED32")]
        Headphone2,

        [Description("\uED33")]
        Headphone3,

        [Description("\uED35")]
        Apps,

        [Description("\uED39")]
        KeyboardBrightness,

        [Description("\uED3A")]
        KeyboardLowerBrightness,

        [Description("\uED3C")]
        SkipBack10,

        [Description("\uED3D")]
        SkipForward30,

        [Description("\uED41")]
        TreeFolderFolder,

        [Description("\uED42")]
        TreeFolderFolderFill,

        [Description("\uED43")]
        TreeFolderFolderOpen,

        [Description("\uED44")]
        TreeFolderFolderOpenFill,

        [Description("\uED47")]
        MultimediaDMP,

        [Description("\uED4C")]
        KeyboardOneHanded,

        [Description("\uED4D")]
        Narrator,

        [Description("\uED53")]
        EmojiTabPeople,

        [Description("\uED54")]
        EmojiTabSmilesAnimals,

        [Description("\uED55")]
        EmojiTabCelebrationObjects,

        [Description("\uED56")]
        EmojiTabFoodPlants,

        [Description("\uED57")]
        EmojiTabTransitPlaces,

        [Description("\uED58")]
        EmojiTabSymbols,

        [Description("\uED59")]
        EmojiTabTextSmiles,

        [Description("\uED5A")]
        EmojiTabFavorites,

        [Description("\uED5B")]
        EmojiSwatch,

        [Description("\uED5C")]
        ConnectApp,

        [Description("\uED5D")]
        CompanionDeviceFramework,

        [Description("\uED5E")]
        Ruler,

        [Description("\uED5F")]
        FingerInking,

        [Description("\uED60")]
        StrokeErase,

        [Description("\uED61")]
        PointErase,

        [Description("\uED62")]
        ClearAllInk,

        [Description("\uED63")]
        Pencil,

        [Description("\uED64")]
        Marker,

        [Description("\uED65")]
        InkingCaret,

        [Description("\uED66")]
        InkingColorOutline,

        [Description("\uED67")]
        InkingColorFill,

        [Description("\uEDA2")]
        HardDrive,

        [Description("\uEDA3")]
        NetworkAdapter,

        [Description("\uEDA4")]
        Touchscreen,

        [Description("\uEDA5")]
        NetworkPrinter,

        [Description("\uEDA6")]
        CloudPrinter,

        [Description("\uEDA7")]
        KeyboardShortcut,

        [Description("\uEDA8")]
        BrushSize,

        [Description("\uEDA9")]
        NarratorForward,

        [Description("\uEDAA")]
        NarratorForwardMirrored,

        [Description("\uEDAB")]
        SyncBadge12,

        [Description("\uEDAC")]
        RingerBadge12,

        [Description("\uEDAD")]
        AsteriskBadge12,

        [Description("\uEDAE")]
        ErrorBadge12,

        [Description("\uEDAF")]
        CircleRingBadge12,

        [Description("\uEDB0")]
        CircleFillBadge12,

        [Description("\uEDB1")]
        ImportantBadge12,

        [Description("\uEDB3")]
        MailBadge12,

        [Description("\uEDB4")]
        PauseBadge12,

        [Description("\uEDB5")]
        PlayBadge12,

        [Description("\uEDC6")]
        PenWorkspace,

        [Description("\uEDD5")]
        CaretLeft8,

        [Description("\uEDD6")]
        CaretRight8,

        [Description("\uEDD7")]
        CaretUp8,

        [Description("\uEDD8")]
        CaretDown8,

        [Description("\uEDD9")]
        CaretLeftSolid8,

        [Description("\uEDDA")]
        CaretRightSolid8,

        [Description("\uEDDB")]
        CaretUpSolid8,

        [Description("\uEDDC")]
        CaretDownSolid8,

        [Description("\uEDE0")]
        Strikethrough,

        [Description("\uEDE1")]
        Export,

        [Description("\uEDE2")]
        ExportMirrored,

        [Description("\uEDE3")]
        ButtonMenu,

        [Description("\uEDE4")]
        CloudSearch,

        [Description("\uEDE5")]
        PinyinIMELogo,

        [Description("\uEDFB")]
        CalligraphyPen,

        [Description("\uEE35")]
        ReplyMirrored,

        [Description("\uEE3F")]
        LockscreenDesktop,

        [Description("\uEE40")]
        TaskViewSettings,

        [Description("\uEE47")]
        MiniExpand2Mirrored,

        [Description("\uEE49")]
        MiniContract2Mirrored,

        [Description("\uEE4A")]
        Play36,

        [Description("\uEE56")]
        PenPalette,

        [Description("\uEE57")]
        GuestUser,

        [Description("\uEE63")]
        SettingsBattery,

        [Description("\uEE64")]
        TaskbarPhone,

        [Description("\uEE65")]
        LockScreenGlance,

        [Description("\uEE6F")]
        GenericScan,

        [Description("\uEE71")]
        ImageExport,

        [Description("\uEE77")]
        WifiEthernet,

        [Description("\uEE79")]
        ActionCenterQuiet,

        [Description("\uEE7A")]
        ActionCenterQuietNotification,

        [Description("\uEE92")]
        TrackersMirrored,

        [Description("\uEE93")]
        DateTimeMirrored,

        [Description("\uEE94")]
        Wheel,

        [Description("\uEEA3")]
        VirtualMachineGroup,

        [Description("\uEECA")]
        ButtonView2,

        [Description("\uEF15")]
        PenWorkspaceMirrored,

        [Description("\uEF16")]
        PenPaletteMirrored,

        [Description("\uEF17")]
        StrokeEraseMirrored,

        [Description("\uEF18")]
        PointEraseMirrored,

        [Description("\uEF19")]
        ClearAllInkMirrored,

        [Description("\uEF1F")]
        BackgroundToggle,

        [Description("\uEF20")]
        Marquee,

        [Description("\uEF2C")]
        ChromeCloseContrast,

        [Description("\uEF2D")]
        ChromeMinimizeContrast,

        [Description("\uEF2E")]
        ChromeMaximizeContrast,

        [Description("\uEF2F")]
        ChromeRestoreContrast,

        [Description("\uEF31")]
        TrafficLight,

        [Description("\uEF3B")]
        Replay,

        [Description("\uEF3C")]
        Eyedropper,

        [Description("\uEF3D")]
        LineDisplay,

        [Description("\uEF3E")]
        PINPad,

        [Description("\uEF3F")]
        SignatureCapture,

        [Description("\uEF40")]
        ChipCardCreditCardReader,

        [Description("\uEF42")]
        MarketDown,

        [Description("\uEF58")]
        PlayerSettings,

        [Description("\uEF6B")]
        LandscapeOrientation,

        [Description("\uEF90")]
        Flow,

        [Description("\uEFA5")]
        Touchpad,

        [Description("\uEFA9")]
        Speech,

        [Description("\uF000")]
        KnowledgeArticle,

        [Description("\uF003")]
        Relationship,

        [Description("\uF012")]
        ZipFolder,

        [Description("\uF080")]
        DefaultAPN,

        [Description("\uF081")]
        UserAPN,

        [Description("\uF085")]
        DoublePinyin,

        [Description("\uF08C")]
        BlueLight,

        [Description("\uF08D")]
        CaretSolidLeft,

        [Description("\uF08E")]
        CaretSolidDown,

        [Description("\uF08F")]
        CaretSolidRight,

        [Description("\uF090")]
        CaretSolidUp,

        [Description("\uF093")]
        ButtonA,

        [Description("\uF094")]
        ButtonB,

        [Description("\uF095")]
        ButtonY,

        [Description("\uF096")]
        ButtonX,

        [Description("\uF0AD")]
        ArrowUp8,

        [Description("\uF0AE")]
        ArrowDown8,

        [Description("\uF0AF")]
        ArrowRight8,

        [Description("\uF0B0")]
        ArrowLeft8,

        [Description("\uF0B2")]
        QuarentinedItems,

        [Description("\uF0B3")]
        QuarentinedItemsMirrored,

        [Description("\uF0B4")]
        Protractor,

        [Description("\uF0B5")]
        ChecklistMirrored,

        [Description("\uF0B6")]
        StatusCircle7,

        [Description("\uF0B7")]
        StatusCheckmark7,

        [Description("\uF0B8")]
        StatusErrorCircle7,

        [Description("\uF0B9")]
        Connected,

        [Description("\uF0C6")]
        PencilFill,

        [Description("\uF0C7")]
        CalligraphyFill,

        [Description("\uF0CA")]
        QuarterStarLeft,

        [Description("\uF0CB")]
        QuarterStarRight,

        [Description("\uF0CC")]
        ThreeQuarterStarLeft,

        [Description("\uF0CD")]
        ThreeQuarterStarRight,

        [Description("\uF0CE")]
        QuietHoursBadge12,

        [Description("\uF0D2")]
        BackMirrored,

        [Description("\uF0D3")]
        ForwardMirrored,

        [Description("\uF0D5")]
        ChromeBackContrast,

        [Description("\uF0D6")]
        ChromeBackContrastMirrored,

        [Description("\uF0D7")]
        ChromeBackToWindowContrast,

        [Description("\uF0D8")]
        ChromeFullScreenContrast,

        [Description("\uF0E2")]
        GridView,

        [Description("\uF0E3")]
        ClipboardList,

        [Description("\uF0E4")]
        ClipboardListMirrored,

        [Description("\uF0E5")]
        OutlineQuarterStarLeft,

        [Description("\uF0E6")]
        OutlineQuarterStarRight,

        [Description("\uF0E7")]
        OutlineHalfStarLeft,

        [Description("\uF0E8")]
        OutlineHalfStarRight,

        [Description("\uF0E9")]
        OutlineThreeQuarterStarLeft,

        [Description("\uF0EA")]
        OutlineThreeQuarterStarRight,

        [Description("\uF0EB")]
        SpatialVolume0,

        [Description("\uF0EC")]
        SpatialVolume1,

        [Description("\uF0ED")]
        SpatialVolume2,

        [Description("\uF0EE")]
        SpatialVolume3,

        [Description("\uF0EF")]
        ApplicationGuard,

        [Description("\uF0F7")]
        OutlineStarLeftHalf,

        [Description("\uF0F8")]
        OutlineStarRightHalf,

        [Description("\uF0F9")]
        ChromeAnnotateContrast,

        [Description("\uF0FB")]
        DefenderBadge12,

        [Description("\uF103")]
        DetachablePC,

        [Description("\uF108")]
        LeftStick,

        [Description("\uF109")]
        RightStick,

        [Description("\uF10A")]
        TriggerLeft,

        [Description("\uF10B")]
        TriggerRight,

        [Description("\uF10C")]
        BumperLeft,

        [Description("\uF10D")]
        BumperRight,

        [Description("\uF10E")]
        Dpad,

        [Description("\uF110")]
        EnglishPunctuation,

        [Description("\uF111")]
        ChinesePunctuation,

        [Description("\uF119")]
        HMD,

        [Description("\uF11B")]
        CtrlSpatialRight,

        [Description("\uF126")]
        PaginationDotOutline10,

        [Description("\uF127")]
        PaginationDotSolid10,

        [Description("\uF128")]
        StrokeErase2,

        [Description("\uF129")]
        SmallErase,

        [Description("\uF12A")]
        LargeErase,

        [Description("\uF12B")]
        FolderHorizontal,

        [Description("\uF12E")]
        MicrophoneListening,

        [Description("\uF12F")]
        StatusExclamationCircle7,

        [Description("\uF131")]
        Video360,

        [Description("\uF133")]
        GiftboxOpen,

        [Description("\uF136")]
        StatusCircleOuter,

        [Description("\uF137")]
        StatusCircleInner,

        [Description("\uF138")]
        StatusCircleRing,

        [Description("\uF139")]
        StatusTriangleOuter,

        [Description("\uF13A")]
        StatusTriangleInner,

        [Description("\uF13B")]
        StatusTriangleExclamation,

        [Description("\uF13C")]
        StatusCircleExclamation,

        [Description("\uF13D")]
        StatusCircleErrorX,

        [Description("\uF13E")]
        StatusCircleCheckmark,

        [Description("\uF13F")]
        StatusCircleInfo,

        [Description("\uF140")]
        StatusCircleBlock,

        [Description("\uF141")]
        StatusCircleBlock2,

        [Description("\uF142")]
        StatusCircleQuestionMark,

        [Description("\uF143")]
        StatusCircleSync,

        [Description("\uF146")]
        Dial1,

        [Description("\uF147")]
        Dial2,

        [Description("\uF148")]
        Dial3,

        [Description("\uF149")]
        Dial4,

        [Description("\uF14A")]
        Dial5,

        [Description("\uF14B")]
        Dial6,

        [Description("\uF14C")]
        Dial7,

        [Description("\uF14D")]
        Dial8,

        [Description("\uF14E")]
        Dial9,

        [Description("\uF14F")]
        Dial10,

        [Description("\uF150")]
        Dial11,

        [Description("\uF151")]
        Dial12,

        [Description("\uF152")]
        Dial13,

        [Description("\uF153")]
        Dial14,

        [Description("\uF154")]
        Dial15,

        [Description("\uF155")]
        Dial16,

        [Description("\uF156")]
        DialShape1,

        [Description("\uF157")]
        DialShape2,

        [Description("\uF158")]
        DialShape3,

        [Description("\uF159")]
        DialShape4,

        [Description("\uF15F")]
        ClosedCaptionsInternational,

        [Description("\uF161")]
        TollSolid,

        [Description("\uF163")]
        TrafficCongestionSolid,

        [Description("\uF164")]
        ExploreContentSingle,

        [Description("\uF165")]
        CollapseContent,

        [Description("\uF166")]
        CollapseContentSingle,

        [Description("\uF167")]
        InfoSolid,

        [Description("\uF168")]
        GroupList,

        [Description("\uF169")]
        CaretBottomRightSolidCenter8,

        [Description("\uF16A")]
        ProgressRingDots,

        [Description("\uF16B")]
        Checkbox14,

        [Description("\uF16C")]
        CheckboxComposite14,

        [Description("\uF16D")]
        CheckboxIndeterminateCombo14,

        [Description("\uF16E")]
        CheckboxIndeterminateCombo,

        [Description("\uF175")]
        StatusPause7,

        [Description("\uF17F")]
        CharacterAppearance,

        [Description("\uF180")]
        Lexicon,

        [Description("\uF182")]
        ScreenTime,

        [Description("\uF191")]
        HeadlessDevice,

        [Description("\uF193")]
        NetworkSharing,

        [Description("\uF19D")]
        EyeGaze,

        [Description("\uF19E")]
        ToggleLeft,

        [Description("\uF19F")]
        ToggleRight,

        [Description("\uF1AD")]
        WindowsInsider,

        [Description("\uF1CB")]
        ChromeSwitch,

        [Description("\uF1CC")]
        ChromeSwitchContast,

        [Description("\uF1D8")]
        StatusCheckmark,

        [Description("\uF1D9")]
        StatusCheckmarkLeft,

        [Description("\uF20C")]
        KeyboardLeftAligned,

        [Description("\uF20D")]
        KeyboardRightAligned,

        [Description("\uF210")]
        KeyboardSettings,

        [Description("\uF211")]
        NetworkPhysical,

        [Description("\uF22C")]
        IOT,

        [Description("\uF22E")]
        UnknownMirrored,

        [Description("\uF246")]
        ViewDashboard,

        [Description("\uF259")]
        ExploitProtectionSettings,

        [Description("\uF260")]
        KeyboardNarrow,

        [Description("\uF261")]
        Keyboard12Key,

        [Description("\uF26B")]
        KeyboardDock,

        [Description("\uF26C")]
        KeyboardUndock,

        [Description("\uF26D")]
        KeyboardLeftDock,

        [Description("\uF26E")]
        KeyboardRightDock,

        [Description("\uF270")]
        Ear,

        [Description("\uF271")]
        PointerHand,

        [Description("\uF272")]
        Bullseye,

        [Description("\uF28B")]
        DocumentApproval,

        [Description("\uF2B7")]
        LocaleLanguage,

        [Description("\uF32A")]
        PassiveAuthentication,

        [Description("\uF354")]
        ColorSolid,

        [Description("\uF384")]
        NetworkOffline,

        [Description("\uF385")]
        NetworkConnected,

        [Description("\uF386")]
        NetworkConnectedCheckmark,

        [Description("\uF3B1")]
        SignOut,

        [Description("\uF3CC")]
        StatusInfo,

        [Description("\uF3CD")]
        StatusInfoLeft,

        [Description("\uF3E2")]
        NearbySharing,

        [Description("\uF3E7")]
        CtrlSpatialLeft,

        [Description("\uF404")]
        InteractiveDashboard,

        [Description("\uF405")]
        DeclineCall,

        [Description("\uF406")]
        ClippingTool,

        [Description("\uF407")]
        RectangularClipping,

        [Description("\uF408")]
        FreeFormClipping,

        [Description("\uF413")]
        CopyTo,

        [Description("\uF427")]
        IDBadge,

        [Description("\uF439")]
        DynamicLock,

        [Description("\uF45E")]
        PenTips,

        [Description("\uF45F")]
        PenTipsMirrored,

        [Description("\uF460")]
        HWPJoin,

        [Description("\uF461")]
        HWPInsert,

        [Description("\uF462")]
        HWPStrikeThrough,

        [Description("\uF463")]
        HWPScratchOut,

        [Description("\uF464")]
        HWPSplit,

        [Description("\uF465")]
        HWPNewLine,

        [Description("\uF466")]
        HWPOverwrite,

        [Description("\uF473")]
        MobWifiWarning1,

        [Description("\uF474")]
        MobWifiWarning2,

        [Description("\uF475")]
        MobWifiWarning3,

        [Description("\uF476")]
        MobWifiWarning4,

        [Description("\uF47F")]
        MicLocationCombo,

        [Description("\uF49A")]
        Globe2,

        [Description("\uF4A5")]
        SpecialEffectSize,

        [Description("\uF4A9")]
        GIF,

        [Description("\uF4AA")]
        Sticker2,

        [Description("\uF4BE")]
        SurfaceHubSelected,

        [Description("\uF4BF")]
        HoloLensSelected,

        [Description("\uF4C0")]
        Earbud,

        [Description("\uF4C3")]
        MixVolumes,

        [Description("\uF540")]
        Safe,

        [Description("\uF552")]
        LaptopSecure,

        [Description("\uF56D")]
        PrintDefault,

        [Description("\uF56E")]
        PageMirrored,

        [Description("\uF56F")]
        LandscapeOrientationMirrored,

        [Description("\uF570")]
        ColorOff,

        [Description("\uF571")]
        PrintAllPages,

        [Description("\uF572")]
        PrintCustomRange,

        [Description("\uF573")]
        PageMarginPortraitNarrow,

        [Description("\uF574")]
        PageMarginPortraitNormal,

        [Description("\uF575")]
        PageMarginPortraitModerate,

        [Description("\uF576")]
        PageMarginPortraitWide,

        [Description("\uF577")]
        PageMarginLandscapeNarrow,

        [Description("\uF578")]
        PageMarginLandscapeNormal,

        [Description("\uF579")]
        PageMarginLandscapeModerate,

        [Description("\uF57A")]
        PageMarginLandscapeWide,

        [Description("\uF57B")]
        CollateLandscape,

        [Description("\uF57C")]
        CollatePortrait,

        [Description("\uF57D")]
        CollatePortraitSeparated,

        [Description("\uF57E")]
        DuplexLandscapeOneSided,

        [Description("\uF57F")]
        DuplexLandscapeOneSidedMirrored,

        [Description("\uF580")]
        DuplexLandscapeTwoSidedLongEdge,

        [Description("\uF581")]
        DuplexLandscapeTwoSidedLongEdgeMirrored,

        [Description("\uF582")]
        DuplexLandscapeTwoSidedShortEdge,

        [Description("\uF583")]
        DuplexLandscapeTwoSidedShortEdgeMirrored,

        [Description("\uF584")]
        DuplexPortraitOneSided,

        [Description("\uF585")]
        DuplexPortraitOneSidedMirrored,

        [Description("\uF586")]
        DuplexPortraitTwoSidedLongEdge,

        [Description("\uF587")]
        DuplexPortraitTwoSidedLongEdgeMirrored,

        [Description("\uF588")]
        DuplexPortraitTwoSidedShortEdge,

        [Description("\uF589")]
        DuplexPortraitTwoSidedShortEdgeMirrored,

        [Description("\uF58A")]
        PPSOneLandscape,

        [Description("\uF58B")]
        PPSTwoLandscape,

        [Description("\uF58C")]
        PPSTwoPortrait,

        [Description("\uF58D")]
        PPSFourLandscape,

        [Description("\uF58E")]
        PPSFourPortrait,

        [Description("\uF58F")]
        HolePunchOff,

        [Description("\uF590")]
        HolePunchPortraitLeft,

        [Description("\uF591")]
        HolePunchPortraitRight,

        [Description("\uF592")]
        HolePunchPortraitTop,

        [Description("\uF593")]
        HolePunchPortraitBottom,

        [Description("\uF594")]
        HolePunchLandscapeLeft,

        [Description("\uF595")]
        HolePunchLandscapeRight,

        [Description("\uF596")]
        HolePunchLandscapeTop,

        [Description("\uF597")]
        HolePunchLandscapeBottom,

        [Description("\uF598")]
        StaplingOff,

        [Description("\uF599")]
        StaplingPortraitTopLeft,

        [Description("\uF59A")]
        StaplingPortraitTopRight,

        [Description("\uF59B")]
        StaplingPortraitBottomRight,

        [Description("\uF59C")]
        StaplingPortraitTwoLeft,

        [Description("\uF59D")]
        StaplingPortraitTwoRight,

        [Description("\uF59E")]
        StaplingPortraitTwoTop,

        [Description("\uF59F")]
        StaplingPortraitTwoBottom,

        [Description("\uF5A0")]
        StaplingPortraitBookBinding,

        [Description("\uF5A1")]
        StaplingLandscapeTopLeft,

        [Description("\uF5A2")]
        StaplingLandscapeTopRight,

        [Description("\uF5A3")]
        StaplingLandscapeBottomLeft,

        [Description("\uF5A4")]
        StaplingLandscapeBottomRight,

        [Description("\uF5A5")]
        StaplingLandscapeTwoLeft,

        [Description("\uF5A6")]
        StaplingLandscapeTwoRight,

        [Description("\uF5A7")]
        StaplingLandscapeTwoTop,

        [Description("\uF5A8")]
        StaplingLandscapeTwoBottom,

        [Description("\uF5A9")]
        StaplingLandscapeBookBinding,

        [Description("\uF5AA")]
        StatusDataTransferRoaming,

        [Description("\uF5AB")]
        MobSIMError,

        [Description("\uF5AC")]
        CollateLandscapeSeparated,

        [Description("\uF5AD")]
        PPSOnePortrait,

        [Description("\uF5AE")]
        StaplingPortraitBottomLeft,

        [Description("\uF5B0")]
        PlaySolid,

        [Description("\uF5E7")]
        RepeatOff,

        [Description("\uF5ED")]
        Set,

        [Description("\uF5EE")]
        SetSolid,

        [Description("\uF5EF")]
        FuzzyReading,

        [Description("\uF5F2")]
        VerticalBattery0,

        [Description("\uF5F3")]
        VerticalBattery1,

        [Description("\uF5F4")]
        VerticalBattery2,

        [Description("\uF5F5")]
        VerticalBattery3,

        [Description("\uF5F6")]
        VerticalBattery4,

        [Description("\uF5F7")]
        VerticalBattery5,

        [Description("\uF5F8")]
        VerticalBattery6,

        [Description("\uF5F9")]
        VerticalBattery7,

        [Description("\uF5FA")]
        VerticalBattery8,

        [Description("\uF5FB")]
        VerticalBattery9,

        [Description("\uF5FC")]
        VerticalBattery10,

        [Description("\uF5FD")]
        VerticalBatteryCharging0,

        [Description("\uF5FE")]
        VerticalBatteryCharging1,

        [Description("\uF5FF")]
        VerticalBatteryCharging2,

        [Description("\uF600")]
        VerticalBatteryCharging3,

        [Description("\uF601")]
        VerticalBatteryCharging4,

        [Description("\uF602")]
        VerticalBatteryCharging5,

        [Description("\uF603")]
        VerticalBatteryCharging6,

        [Description("\uF604")]
        VerticalBatteryCharging7,

        [Description("\uF605")]
        VerticalBatteryCharging8,

        [Description("\uF606")]
        VerticalBatteryCharging9,

        [Description("\uF607")]
        VerticalBatteryCharging10,

        [Description("\uF608")]
        VerticalBatteryUnknown,

        [Description("\uF618")]
        SIMError,

        [Description("\uF619")]
        SIMMissing,

        [Description("\uF61A")]
        SIMLock,

        [Description("\uF61B")]
        eSIM,

        [Description("\uF61C")]
        eSIMNoProfile,

        [Description("\uF61D")]
        eSIMLocked,

        [Description("\uF61E")]
        eSIMBusy,

        [Description("\uF61F")]
        NoiseCancelation,

        [Description("\uF620")]
        NoiseCancelationOff,

        [Description("\uF623")]
        MusicSharing,

        [Description("\uF624")]
        MusicSharingOff,

        [Description("\uF63C")]
        CircleShapeSolid,

        [Description("\uF657")]
        WifiCallBars,

        [Description("\uF658")]
        WifiCall0,

        [Description("\uF659")]
        WifiCall1,

        [Description("\uF65A")]
        WifiCall2,

        [Description("\uF65B")]
        WifiCall3,

        [Description("\uF65C")]
        WifiCall4,

        [Description("\uF69E")]
        CHTLanguageBar,

        [Description("\uF6A9")]
        ComposeMode,

        [Description("\uF6B8")]
        ExpressiveInputEntry,

        [Description("\uF6BA")]
        EmojiTabMoreSymbols,

        [Description("\uF6FA")]
        WebSearch,

        [Description("\uF712")]
        Kiosk,

        [Description("\uF714")]
        RTTLogo,

        [Description("\uF715")]
        VoiceCall,

        [Description("\uF716")]
        GoToMessage,

        [Description("\uF71A")]
        ReturnToCall,

        [Description("\uF71C")]
        StartPresenting,

        [Description("\uF71D")]
        StopPresenting,

        [Description("\uF71E")]
        ProductivityMode,

        [Description("\uF738")]
        SetHistoryStatus,

        [Description("\uF739")]
        SetHistoryStatus2,

        [Description("\uF73D")]
        Keyboardsettings20,

        [Description("\uF73E")]
        OneHandedRight20,

        [Description("\uF73F")]
        OneHandedLeft20,

        [Description("\uF740")]
        Split20,

        [Description("\uF741")]
        Full20,

        [Description("\uF742")]
        Handwriting20,

        [Description("\uF743")]
        ChevronLeft20,

        [Description("\uF744")]
        ChevronLeft32,

        [Description("\uF745")]
        ChevronRight20,

        [Description("\uF746")]
        ChevronRight32,

        [Description("\uF763")]
        Event12,

        [Description("\uF781")]
        MicOff2,

        [Description("\uF785")]
        DeliveryOptimization,

        [Description("\uF78A")]
        CancelMedium,

        [Description("\uF78B")]
        SearchMedium,

        [Description("\uF78C")]
        AcceptMedium,

        [Description("\uF78D")]
        RevealPasswordMedium,

        [Description("\uF7AD")]
        DeleteWord,

        [Description("\uF7AE")]
        DeleteWordFill,

        [Description("\uF7AF")]
        DeleteLines,

        [Description("\uF7B0")]
        DeleteLinesFill,

        [Description("\uF7B1")]
        InstertWords,

        [Description("\uF7B2")]
        InstertWordsFill,

        [Description("\uF7B3")]
        JoinWords,

        [Description("\uF7B4")]
        JoinWordsFill,

        [Description("\uF7B5")]
        OverwriteWords,

        [Description("\uF7B6")]
        OverwriteWordsFill,

        [Description("\uF7B7")]
        AddNewLine,

        [Description("\uF7B8")]
        AddNewLineFill,

        [Description("\uF7B9")]
        OverwriteWordsKorean,

        [Description("\uF7BA")]
        OverwriteWordsFillKorean,

        [Description("\uF7BB")]
        EducationIcon,

        [Description("\uF7ED")]
        WindowSnipping,

        [Description("\uF7EE")]
        VideoCapture,

        [Description("\uF809")]
        StatusSecured,

        [Description("\uF83B")]
        NarratorApp,

        [Description("\uF83D")]
        PowerButtonUpdate,

        [Description("\uF83E")]
        RestartUpdate,

        [Description("\uF83F")]
        UpdateStatusDot,

        [Description("\uF847")]
        Eject,

        [Description("\uF87B")]
        Spelling,

        [Description("\uF87C")]
        SpellingKorean,

        [Description("\uF87D")]
        SpellingSerbian,

        [Description("\uF87E")]
        SpellingChinese,

        [Description("\uF89A")]
        FolderSelect,

        [Description("\uF8A5")]
        SmartScreen,

        [Description("\uF8A6")]
        ExploitProtection,

        [Description("\uF8AA")]
        AddBold,

        [Description("\uF8AB")]
        SubtractBold,

        [Description("\uF8AC")]
        BackSolidBold,

        [Description("\uF8AD")]
        ForwardSolidBold,

        [Description("\uF8AE")]
        PauseBold,

        [Description("\uF8AF")]
        ClickSolid,

        [Description("\uF8B0")]
        SettingsSolid,

        [Description("\uF8B1")]
        MicrophoneSolidBold,

        [Description("\uF8B2")]
        SpeechSolidBold,

        [Description("\uF8B3")]
        ClickedOutLoudSolidBold,

    }
}
