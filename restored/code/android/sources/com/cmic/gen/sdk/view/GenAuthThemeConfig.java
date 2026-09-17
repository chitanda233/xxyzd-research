package com.cmic.gen.sdk.view;

import android.R;
import android.text.TextUtils;
import android.view.View;
import android.widget.ImageView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes2.dex */
public class GenAuthThemeConfig {
    public static final String PLACEHOLDER = "$$运营商条款$$";
    private int A;
    private int B;
    private int C;
    private int D;
    private int E;
    private boolean F;
    private int G;
    private int H;
    private int I;
    private int J;
    private String K;
    private boolean L;
    private int M;
    private boolean N;
    private int O;
    private String P;
    private int Q;
    private int R;
    private int S;
    private int T;
    private int U;
    private int V;
    private String W;
    private boolean X;
    private GenBackPressedListener Y;
    private GenLoginClickListener Z;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final boolean f2136a;
    private int aA;
    private int aB;
    private int aC;
    private int aD;
    private int aE;
    private boolean aF;
    private String aG;
    private String aH;
    private String aI;
    private String aJ;
    private int aK;
    private int aL;
    private int aM;
    private int aN;
    private int aO;
    private int aP;
    private int aQ;
    private int aR;
    private boolean aS;
    private boolean aT;
    private String aU;
    private GenCheckBoxListener aa;
    private GenCheckedChangeListener ab;
    private GenAuthLoginListener ac;
    private ClauseClickListener ad;
    private String ae;
    private String af;
    private int ag;
    private int ah;
    private boolean ai;
    private String aj;
    private boolean ak;
    private String al;
    private String am;
    private String an;
    private String ao;
    private String ap;
    private String aq;
    private String ar;
    private String as;
    private boolean at;
    private int au;
    private boolean av;
    private boolean aw;
    private int ax;
    private int ay;
    private boolean az;
    private int b;
    private boolean c;
    private View d;
    private int e;
    private int f;
    private String g;
    private boolean h;
    private int i;
    private int j;
    private int k;
    private boolean l;
    private int m;
    private String n;
    private int o;
    private int p;
    private ImageView.ScaleType q;
    private int r;
    private int s;
    private int t;
    private int u;
    private int v;
    private ImageView.ScaleType w;
    private boolean x;
    private int y;
    private boolean z;

    public int getStatusBarColor() {
        return this.b;
    }

    public boolean isLightColor() {
        return this.c;
    }

    public View getContentView() {
        return this.d;
    }

    public int getLayoutResID() {
        return this.e;
    }

    public int getClauseLayoutResID() {
        return this.f;
    }

    public String getClauseLayoutReturnID() {
        return this.g;
    }

    public boolean isGetWebViewTitle() {
        return this.h;
    }

    public int getNavTextSize() {
        return this.i;
    }

    public int getNavTextColor() {
        return this.j;
    }

    public int getNavColor() {
        return this.k;
    }

    public boolean isNavHidden() {
        return this.l;
    }

    public int getClauseStatusColor() {
        return this.m;
    }

    public String getNavReturnImgPath() {
        return this.n;
    }

    public int getNavReturnImgWidth() {
        return this.o;
    }

    public int getNavReturnImgHeight() {
        return this.p;
    }

    public ImageView.ScaleType getNavReturnImgScaleType() {
        return this.q;
    }

    public int getLogoWidth() {
        return this.r;
    }

    public int getLogoHeight() {
        return this.s;
    }

    public int getLogoOffsetX() {
        return this.t;
    }

    public ImageView.ScaleType getLogoScaleType() {
        return this.w;
    }

    public int getLogoOffsetY() {
        return this.u;
    }

    public int getLogoOffsetY_B() {
        return this.v;
    }

    public boolean isDisplayLogo() {
        return this.x;
    }

    public int getNumberSize() {
        return this.y;
    }

    public boolean isNumberBold() {
        return this.z;
    }

    public int getNumberColor() {
        return this.A;
    }

    public int getNumberOffsetX() {
        return this.B;
    }

    public int getNumFieldOffsetY() {
        return this.C;
    }

    public int getNumFieldOffsetY_B() {
        return this.D;
    }

    public int getProvideTextOffsetY() {
        return this.I;
    }

    public int getProvideTextOffsetX() {
        return this.H;
    }

    public int getProvideTextSize() {
        return this.E;
    }

    public int getProvideTextOffsetY_B() {
        return this.J;
    }

    public int getProvideTextColor() {
        return this.G;
    }

    public boolean getProvideTextBold() {
        return this.F;
    }

    public String getLogBtnText() {
        String str;
        if (this.L) {
            int i = this.aR;
            if (i == 1) {
                str = "本機號碼登錄";
            } else {
                str = i == 2 ? "Login" : this.K;
            }
            this.K = str;
        }
        return this.K;
    }

    public int getLogBtnTextSize() {
        return this.M;
    }

    public boolean isLogBtnTextBold() {
        return this.N;
    }

    public int getLogBtnTextColor() {
        return this.O;
    }

    public String getLogBtnBackgroundPath() {
        return this.P;
    }

    public int getLogBtnWidth() {
        return this.Q;
    }

    public int getLogBtnHeight() {
        return this.R;
    }

    public int getLogBtnMarginLeft() {
        return this.S;
    }

    public int getLogBtnMarginRight() {
        return this.T;
    }

    public int getLogBtnOffsetY() {
        return this.U;
    }

    public int getLogBtnOffsetY_B() {
        return this.V;
    }

    public String getCheckTipText() {
        String str;
        if (this.X) {
            int i = this.aR;
            if (i == 1) {
                str = "請勾選同意服務條款";
            } else {
                str = i == 2 ? "Please check to agree to the terms of service" : "请勾选同意服务条款";
            }
            this.W = str;
        }
        return this.W;
    }

    public GenBackPressedListener getGenBackPressedListener() {
        return this.Y;
    }

    public GenLoginClickListener getGenLoginClickListener() {
        return this.Z;
    }

    public GenCheckBoxListener getGenCheckBoxListener() {
        return this.aa;
    }

    public GenCheckedChangeListener getGenCheckedChangeListener() {
        return this.ab;
    }

    public ClauseClickListener getClauseClickListener() {
        return this.ad;
    }

    public GenAuthLoginListener getGenAuthLoginListener() {
        return this.ac;
    }

    public String getCheckedImgPath() {
        return this.ae;
    }

    public String getUncheckedImgPath() {
        return this.af;
    }

    public int getCheckedImgWidth() {
        return this.ag;
    }

    public int getCheckedImgHeight() {
        return this.ah;
    }

    public boolean isPrivacyState() {
        return this.ai;
    }

    public String getPrivacy() {
        String str;
        if (this.ak) {
            int i = this.aR;
            if (i == 1) {
                str = "登錄即同意%s並使用本機號碼登錄";
            } else {
                str = i == 2 ? "By logging in, you agree to the %s and use your local phone number to log in" : "登录即同意%s并使用本机号码登录";
            }
            return String.format(str, PLACEHOLDER);
        }
        return this.aj;
    }

    public String getClauseName() {
        return this.al;
    }

    public String getClauseUrl() {
        return this.am;
    }

    public String getClauseName2() {
        return this.an;
    }

    public String getClauseUrl2() {
        return this.ao;
    }

    public String getClauseName3() {
        return this.ap;
    }

    public String getClauseUrl3() {
        return this.aq;
    }

    public String getClauseName4() {
        return this.ar;
    }

    public String getClauseUrl4() {
        return this.as;
    }

    public int getPrivacyTextSize() {
        return this.au;
    }

    public boolean isPrivacyTextBold() {
        return this.aw;
    }

    public int getClauseBaseColor() {
        return this.ax;
    }

    public int getClauseColor() {
        return this.ay;
    }

    public boolean isPrivacyTextGravityCenter() {
        return this.az;
    }

    public int getPrivacyMarginLeft() {
        return this.aB;
    }

    public int getPrivacyMarginRight() {
        return this.aC;
    }

    public int getPrivacyOffsetY() {
        return this.aD;
    }

    public int getPrivacyOffsetY_B() {
        return this.aE;
    }

    public boolean isPrivacyBookSymbol() {
        return this.aF;
    }

    public int getCheckBoxLocation() {
        return this.aA;
    }

    public String getAuthPageActIn() {
        return this.aG;
    }

    public String getActivityOut() {
        return this.aH;
    }

    public String getAuthPageActOut() {
        return this.aI;
    }

    public String getActivityIn() {
        return this.aJ;
    }

    public int getWindowWidth() {
        return this.aK;
    }

    public int getWindowHeight() {
        return this.aL;
    }

    public int getWindowX() {
        return this.aM;
    }

    public int getWindowY() {
        return this.aN;
    }

    public int getWindowBottom() {
        return this.aO;
    }

    public int getThemeId() {
        return this.aP;
    }

    public int getPrivacyDialogThemeId() {
        return this.aQ;
    }

    public int getAppLanguageType() {
        return this.aR;
    }

    public boolean isFitsSystemWindows() {
        return this.aS;
    }

    public boolean isBackButton() {
        return this.aT;
    }

    public String getPrivacyAnimation() {
        return this.aU;
    }

    public boolean getWebStorage() {
        return this.f2136a;
    }

    public boolean isCheckBoxAccurateClick() {
        return this.at;
    }

    public boolean isPrivacyPageFullScreen() {
        return this.av;
    }

    private GenAuthThemeConfig(Builder builder) {
        this.L = true;
        this.ap = null;
        this.aq = null;
        this.ar = null;
        this.as = null;
        this.b = builder.b;
        this.c = builder.c;
        this.d = builder.d;
        this.e = builder.e;
        this.f = builder.f;
        this.g = builder.g;
        this.h = builder.h;
        this.i = builder.i;
        this.j = builder.j;
        this.k = builder.k;
        this.l = builder.l;
        this.m = builder.m;
        this.n = builder.n;
        this.o = builder.o;
        this.p = builder.p;
        this.q = builder.q;
        this.t = builder.t;
        this.r = builder.r;
        this.s = builder.s;
        this.u = builder.u;
        this.v = builder.v;
        this.w = builder.w;
        this.x = builder.x;
        this.y = builder.y;
        this.z = builder.z;
        this.A = builder.A;
        this.B = builder.B;
        this.C = builder.C;
        this.D = builder.D;
        this.E = builder.E;
        this.F = builder.F;
        this.G = builder.G;
        this.H = builder.H;
        this.I = builder.I;
        this.J = builder.J;
        this.K = builder.K;
        this.L = builder.L;
        this.M = builder.M;
        this.N = builder.N;
        this.O = builder.O;
        this.P = builder.P;
        this.Q = builder.Q;
        this.R = builder.R;
        this.S = builder.S;
        this.T = builder.T;
        this.U = builder.U;
        this.V = builder.V;
        this.W = builder.W;
        this.X = builder.X;
        this.Y = builder.Y;
        this.Z = builder.Z;
        this.aa = builder.aa;
        this.ab = builder.ab;
        this.ad = builder.ac;
        this.ae = builder.ae;
        this.af = builder.af;
        this.ag = builder.ag;
        this.ah = builder.ah;
        this.at = builder.ai;
        this.ai = builder.aj;
        this.av = builder.av;
        this.aj = builder.al;
        this.ak = builder.ak;
        this.al = builder.am;
        this.am = builder.an;
        this.an = builder.ao;
        this.ao = builder.ap;
        this.ap = builder.aq;
        this.aq = builder.ar;
        this.ar = builder.as;
        this.as = builder.at;
        this.au = builder.au;
        this.aw = builder.aw;
        this.ax = builder.ax;
        this.ay = builder.ay;
        this.az = builder.az;
        this.aB = builder.aA;
        this.aC = builder.aB;
        this.aD = builder.aC;
        this.aE = builder.aD;
        this.aF = builder.aE;
        this.aA = builder.aF;
        this.aG = builder.aG;
        this.aH = builder.aH;
        this.aI = builder.aI;
        this.aJ = builder.aJ;
        this.aK = builder.aK;
        this.aL = builder.aL;
        this.aM = builder.aM;
        this.aN = builder.aN;
        this.aO = builder.aO;
        this.aP = builder.aP;
        this.aQ = builder.aQ;
        this.aR = builder.aR;
        this.aS = builder.aS;
        this.aT = builder.aT;
        this.aU = builder.aU;
        this.f2136a = builder.f2137a;
        this.ac = builder.ad;
    }

    public static class Builder {
        private String W;
        private boolean X;
        private GenBackPressedListener Y;
        private GenLoginClickListener Z;

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public boolean f2137a;
        private int aF;
        private String aG;
        private String aH;
        private String aI;
        private String aJ;
        private int aK;
        private int aL;
        private int aM;
        private int aN;
        private String aU;
        private GenCheckBoxListener aa;
        private GenCheckedChangeListener ab;
        private ClauseClickListener ac;
        private GenAuthLoginListener ad;
        private String g;
        private boolean h;
        private boolean l;
        private ImageView.ScaleType w;
        private int b = 0;
        private boolean c = false;
        private View d = null;
        private int e = -1;
        private int f = -1;
        private int i = 17;
        private int j = -1;
        private int k = -16742704;
        private int m = -16742704;
        private String n = "return_bg";
        private int o = -2;
        private int p = -2;
        private ImageView.ScaleType q = ImageView.ScaleType.CENTER;
        private int r = 58;
        private int s = 20;
        private int t = -1;
        private int u = -1;
        private int v = -1;
        private boolean x = true;
        private int y = 18;
        private boolean z = false;
        private int A = -16742704;
        private int B = 0;
        private int C = MediaPlayer.MEDIA_PLAYER_OPTION_HW_CONTROL_BY_OPPO;
        private int D = 0;
        private int E = 12;
        private boolean F = false;
        private int G = -16742704;
        private int H = -1;
        private int I = -1;
        private int J = -1;
        private String K = "本机号码一键登录";
        private boolean L = true;
        private int M = 15;
        private boolean N = false;
        private int O = -1;
        private String P = "umcsdk_login_btn_bg";
        private int Q = -1;
        private int R = 36;
        private int S = 46;
        private int T = 46;
        private int U = MediaPlayer.MEDIA_PLAYER_ADAPTIVE_WORK_AROUND_MODE;
        private int V = 0;
        private String ae = "umcsdk_check_image";
        private String af = "umcsdk_uncheck_image";
        private int ag = 9;
        private int ah = 9;
        private boolean ai = false;
        private boolean aj = false;
        private boolean ak = true;
        private String al = "登录即同意$$运营商条款$$并使用本机号码登录";
        private String am = null;
        private String an = null;
        private String ao = null;
        private String ap = null;
        private String aq = null;
        private String ar = null;
        private String as = null;
        private String at = null;
        private int au = 10;
        private boolean av = false;
        private boolean aw = false;
        private int ax = -10066330;
        private int ay = -16007674;
        private boolean az = false;
        private int aA = 52;
        private int aB = 52;
        private int aC = 0;
        private int aD = 30;
        private boolean aE = true;
        private int aO = 0;
        private int aP = -1;
        private int aQ = R.style.Theme.Translucent.NoTitleBar;
        private int aR = 0;
        private boolean aS = true;
        private boolean aT = true;

        public Builder setStatusBar(int i, boolean z) {
            this.b = i;
            this.c = z;
            return this;
        }

        public Builder setAuthContentView(View view) {
            this.d = view;
            this.e = -1;
            return this;
        }

        public Builder setAuthLayoutResID(int i) {
            this.e = i;
            this.d = null;
            return this;
        }

        public Builder setClauseLayoutResID(int i, String str) {
            this.f = i;
            this.g = str;
            return this;
        }

        public Builder setNavTextGetWebViewTittle(boolean z) {
            this.h = z;
            return this;
        }

        public Builder setNavTextSize(int i) {
            this.i = i;
            return this;
        }

        public Builder setNavTextColor(int i) {
            this.j = i;
            return this;
        }

        public Builder setNavColor(int i) {
            this.k = i;
            return this;
        }

        public Builder setNavHidden(boolean z) {
            this.l = z;
            return this;
        }

        public Builder setClauseStatusColor(int i) {
            this.m = i;
            return this;
        }

        public Builder setLogo(int i, int i2) {
            this.r = i;
            this.s = i2;
            return this;
        }

        public Builder displayLogo(boolean z) {
            this.x = z;
            return this;
        }

        public Builder setLogoOffsetX(int i) {
            this.t = i;
            return this;
        }

        public Builder setLogoOffsetY(int i) {
            this.u = i;
            this.v = -1;
            return this;
        }

        public Builder setLogoScaleType(ImageView.ScaleType scaleType) {
            this.w = scaleType;
            return this;
        }

        public Builder setLogoOffsetY_B(int i) {
            this.v = i;
            this.u = -1;
            return this;
        }

        public Builder setNumberSize(int i, boolean z) {
            if (i > 8) {
                this.y = i;
                this.z = z;
            }
            return this;
        }

        public Builder setNumberColor(int i) {
            this.A = i;
            return this;
        }

        public Builder setNumberOffsetX(int i) {
            this.B = i;
            return this;
        }

        public Builder setNumFieldOffsetY(int i) {
            this.C = i;
            this.D = 0;
            return this;
        }

        public Builder setNumFieldOffsetY_B(int i) {
            this.D = i;
            this.C = 0;
            return this;
        }

        public Builder setProvideTextSize(int i, boolean z) {
            if (i > 3) {
                this.E = i;
            }
            this.F = z;
            return this;
        }

        public Builder setProvideTextColor(int i) {
            this.G = i;
            return this;
        }

        public Builder setProvideTextOffsetX(int i) {
            this.H = i;
            return this;
        }

        public Builder setProvideTextOffsetY(int i) {
            this.I = i;
            this.J = -1;
            return this;
        }

        public Builder setProvideTextOffsetY_B(int i) {
            this.J = i;
            this.I = -1;
            return this;
        }

        public Builder setLogBtnText(String str) {
            if (!TextUtils.isEmpty(str) && !Pattern.compile("^\\s*\\n*$").matcher(str).matches()) {
                this.K = str;
                this.L = false;
            }
            return this;
        }

        public Builder setLogBtnText(String str, int i, int i2, boolean z) {
            if (!TextUtils.isEmpty(str) && !Pattern.compile("^\\s*\\n*$").matcher(str).matches()) {
                this.K = str;
                this.L = false;
            }
            this.O = i;
            this.M = i2;
            this.N = z;
            return this;
        }

        public Builder setLogBtnTextColor(int i) {
            this.O = i;
            return this;
        }

        public Builder setLogBtnImgPath(String str) {
            this.P = str;
            return this;
        }

        public Builder setLogBtn(int i, int i2) {
            this.Q = i;
            this.R = i2;
            return this;
        }

        public Builder setLogBtnMargin(int i, int i2) {
            this.S = i;
            this.T = i2;
            return this;
        }

        public Builder setLogBtnOffsetY(int i) {
            this.U = i;
            this.V = 0;
            return this;
        }

        public Builder setGenBackPressedListener(GenBackPressedListener genBackPressedListener) {
            this.Y = genBackPressedListener;
            return this;
        }

        public Builder setLogBtnClickListener(GenLoginClickListener genLoginClickListener) {
            this.Z = genLoginClickListener;
            return this;
        }

        public Builder setGenCheckBoxListener(GenCheckBoxListener genCheckBoxListener) {
            this.aa = genCheckBoxListener;
            return this;
        }

        public Builder setGenCheckedChangeListener(GenCheckedChangeListener genCheckedChangeListener) {
            this.ab = genCheckedChangeListener;
            return this;
        }

        public Builder setClauseClickListener(ClauseClickListener clauseClickListener) {
            this.ac = clauseClickListener;
            return this;
        }

        public Builder setGenAuthLoginListener(GenAuthLoginListener genAuthLoginListener) {
            this.ad = genAuthLoginListener;
            return this;
        }

        public Builder setLogBtnOffsetY_B(int i) {
            this.V = i;
            this.U = 0;
            return this;
        }

        public Builder setCheckTipText(String str) {
            boolean z = TextUtils.isEmpty(str) || str.length() > 100;
            this.X = z;
            if (z) {
                str = "请勾选同意服务条款";
            }
            this.W = str;
            return this;
        }

        public Builder setCheckedImgPath(String str) {
            this.ae = str;
            return this;
        }

        public Builder setUncheckedImgPath(String str) {
            this.af = str;
            return this;
        }

        public Builder setCheckBoxImgPath(String str, String str2, int i, int i2) {
            this.ae = str;
            this.af = str2;
            this.ag = i;
            this.ah = i2;
            return this;
        }

        public Builder setCheckBoxAccurateClick(boolean z) {
            this.ai = z;
            return this;
        }

        public Builder setPrivacyState(boolean z) {
            this.aj = z;
            return this;
        }

        public Builder setPrivacyAlignment(String str, String str2, String str3, String str4, String str5, String str6, String str7, String str8, String str9) {
            if (str.contains(GenAuthThemeConfig.PLACEHOLDER)) {
                this.ak = false;
                this.al = str;
                this.am = str2;
                this.an = str3;
                this.ao = str4;
                this.ap = str5;
                this.aq = str6;
                this.ar = str7;
                this.as = str8;
                this.at = str9;
            }
            return this;
        }

        public Builder setPrivacyText(int i, int i2, int i3, boolean z, boolean z2) {
            this.au = i;
            this.ax = i2;
            this.ay = i3;
            this.az = z;
            this.aw = z2;
            return this;
        }

        public Builder setPrivacyPageFullScreen(boolean z) {
            this.av = z;
            return this;
        }

        public Builder setClauseColor(int i, int i2) {
            this.ax = i;
            this.ay = i2;
            return this;
        }

        public Builder setPrivacyMargin(int i, int i2) {
            this.aA = i;
            this.aB = i2;
            return this;
        }

        public Builder setPrivacyOffsetY(int i) {
            this.aC = i;
            this.aD = 0;
            return this;
        }

        public Builder setPrivacyOffsetY_B(int i) {
            this.aD = i;
            this.aC = 0;
            return this;
        }

        public Builder setPrivacyBookSymbol(boolean z) {
            this.aE = z;
            return this;
        }

        public Builder setCheckBoxLocation(int i) {
            this.aF = i;
            return this;
        }

        public Builder setAuthPageActIn(String str, String str2) {
            this.aG = str;
            this.aH = str2;
            return this;
        }

        public Builder setAuthPageActOut(String str, String str2) {
            this.aI = str2;
            this.aJ = str;
            return this;
        }

        public Builder setAuthPageWindowMode(int i, int i2) {
            this.aK = i;
            this.aL = i2;
            return this;
        }

        public Builder setAuthPageWindowOffset(int i, int i2) {
            this.aM = i;
            this.aN = i2;
            return this;
        }

        public Builder setWindowBottom(int i) {
            this.aO = i;
            return this;
        }

        public Builder setThemeId(int i) {
            this.aP = i;
            return this;
        }

        public Builder setClauseTheme(int i) {
            this.aQ = i;
            return this;
        }

        public Builder setAppLanguageType(int i) {
            this.aR = i;
            return this;
        }

        public Builder setFitsSystemWindows(boolean z) {
            this.aS = z;
            return this;
        }

        public Builder setBackButton(boolean z) {
            this.aT = z;
            return this;
        }

        public Builder setPrivacyAnimation(String str) {
            this.aU = str;
            return this;
        }

        public GenAuthThemeConfig build() {
            return new GenAuthThemeConfig(this);
        }

        public Builder setWebDomStorage(boolean z) {
            this.f2137a = z;
            return this;
        }
    }
}
