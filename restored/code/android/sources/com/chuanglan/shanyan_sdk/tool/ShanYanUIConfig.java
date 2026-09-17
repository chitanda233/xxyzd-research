package com.chuanglan.shanyan_sdk.tool;

import android.graphics.drawable.Drawable;
import android.view.View;
import android.widget.Toast;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.chuanglan.shanyan_sdk.AbstractC0600f;
import com.chuanglan.shanyan_sdk.listener.ShanYanCustomInterface;
import com.chuanglan.shanyan_sdk.r0;
import com.chuanglan.shanyan_sdk.s0;
import com.chuanglan.shanyan_sdk.x0;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/* JADX INFO: loaded from: classes2.dex */
public class ShanYanUIConfig {
    private final boolean A;
    private final boolean A0;
    private final int A1;
    private final int B;
    private final boolean B0;
    private final int B1;
    private final int C;
    private final int C0;
    private final int C1;
    private final Drawable D;
    private final int D0;
    private final boolean D1;
    private final int E;
    private final boolean E0;
    private final s0 E1;
    private final int F;
    private final int F0;
    private final ArrayList F1;
    private final int G;
    private final boolean G0;
    private final boolean H;
    private final boolean H0;
    private final int I;
    private final String I0;
    private final int J;
    private final String J0;
    private final int K;
    private final String K0;
    private final int L;
    private final String L0;
    private final int M;
    private final String M0;
    private final boolean N;
    private final int N0;
    private final Drawable O;
    private final List O0;
    private final int P;
    private final List P0;
    private final int Q;
    private final int Q0;
    private final int R;
    private final int R0;
    private final boolean S;
    private final float S0;
    private final int T;
    private final float T0;
    private final int U;
    private final int U0;
    private final int V;
    private final int V0;
    private final int W;
    private final int W0;
    private final boolean X;
    private final int X0;
    private final int Y;
    private final int Y0;
    private final int Z;
    private final int Z0;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final boolean f2012a;
    private final int a0;
    private final int a1;
    private final boolean b;
    private final int b0;
    private final int b1;
    private final Drawable c;
    private final boolean c0;
    private final boolean c1;
    private final String d;
    private final int d0;
    private final Toast d1;
    private final String e;
    private final boolean e0;
    private final String e1;
    private final boolean f;
    private final int f0;
    private final boolean f1;
    private final int g;
    private final String g0;
    private final boolean g1;
    private final int h;
    private final boolean h0;
    private final int h1;
    private final boolean i;
    private final int i0;
    private final int i1;
    private final boolean j;
    private final int j0;
    private final int j1;
    private final boolean k;
    private final int k0;
    private final int k1;
    private final boolean l;
    private final int l0;
    private final float l1;
    private final boolean m;
    private final int m0;
    private View m1;
    private final boolean n;
    private final Drawable n0;
    private View n1;
    private final boolean o;
    private final int o0;
    private final String o1;
    private final boolean p;
    private final int p0;
    private final String p1;
    private final boolean q;
    private final int q0;
    private final String q1;
    private final boolean r;
    private final boolean r0;
    private final String r1;
    private final int s;
    private final Drawable s0;
    private final String[] s1;
    private final String t;
    private final Drawable t0;
    private final int t1;
    private final int u;
    private final boolean u0;
    private final int u1;
    private final int v;
    private final boolean v0;
    private final int v1;
    private final boolean w;
    private final boolean w0;
    private final boolean w1;
    private final boolean x;
    private final boolean x0;
    private final int x1;
    private final boolean y;
    private final boolean y0;
    private final Drawable y1;
    private final boolean z;
    private final boolean z0;
    private final int z1;

    public static class Builder {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private Drawable f2013a = null;
        private String b = null;
        private String c = null;
        private int d = -1;
        private int e = -1;
        private boolean f = false;
        private boolean g = false;
        private boolean h = false;
        private boolean i = true;
        private boolean j = false;
        private boolean k = false;
        private boolean l = false;
        private boolean m = false;
        private boolean n = false;
        private boolean o = false;
        private boolean p = false;
        private boolean q = true;
        private boolean r = false;
        private int s = -1;
        private String t = "免密登录";
        private int u = -16250872;
        private int v = 16;
        private boolean w = false;
        private boolean x = true;
        private boolean y = true;
        private boolean z = false;
        private boolean A = false;
        private int B = 25;
        private Drawable C = null;
        private int D = 0;
        private int E = -1;
        private int F = -1;
        private int G = 25;
        private boolean H = false;
        private int I = 50;
        private int J = -1;
        private int K = -1;
        private int L = 75;
        private int M = 75;
        private boolean N = false;
        private Drawable O = null;
        private int P = -1;
        private int Q = -1;
        private int R = -13421773;
        private boolean S = false;
        private int T = MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_CODEC_ID;
        private int U = -1;
        private int V = -1;
        private int W = 18;
        private boolean X = false;
        private int Y = MediaPlayer.MEDIA_PLAYER_OPTION_LOOP_PERFER_VIDEO;
        private int Z = -1;
        private int a0 = -1;
        private int b0 = -6710887;
        private boolean c0 = false;
        private int d0 = 10;
        private boolean e0 = false;
        private int f0 = 15;
        private String g0 = "本机号码一键登录";
        private boolean h0 = false;
        private int i0 = MediaPlayer.MEDIA_PLAYER_OPTION_FASTOPEN_LIVE_STREAM;
        private int j0 = -1;
        private int k0 = -1;
        private int l0 = -1;
        private int m0 = -1;
        private Drawable n0 = null;
        private int o0 = -1;
        private int p0 = 46;
        private int q0 = -1;
        private boolean r0 = false;
        private Drawable s0 = null;
        private Drawable t0 = null;
        private boolean u0 = false;
        private boolean v0 = true;
        private boolean w0 = true;
        private boolean x0 = true;
        private boolean y0 = false;
        private boolean z0 = false;
        private boolean A0 = true;
        private boolean B0 = false;
        private int C0 = -1;
        private int D0 = 30;
        private boolean E0 = false;
        private int F0 = -1;
        private boolean G0 = false;
        private boolean H0 = false;
        private String I0 = "同意";
        private String J0 = "和";
        private String K0 = "、";
        private String L0 = "、";
        private String M0 = "并授权获取本机号码";
        private int N0 = 10;
        private List O0 = new ArrayList();
        private List P0 = null;
        private int Q0 = -10066330;
        private int R0 = -16742960;
        private float S0 = -1.0f;
        private float T0 = -1.0f;
        private int U0 = 13;
        private int V0 = 13;
        private int W0 = 10;
        private int X0 = 10;
        private int Y0 = 10;
        private int Z0 = 10;
        private int a1 = -1;
        private int b1 = -1;
        private boolean c1 = false;
        private Toast d1 = null;
        private String e1 = "请勾选协议";
        private boolean f1 = false;
        private boolean g1 = false;
        private int h1 = 300;
        private int i1 = 500;
        private int j1 = 0;
        private int k1 = 0;
        private float l1 = -1.0f;
        private View m1 = null;
        private View n1 = null;
        private String o1 = null;
        private String p1 = null;
        private String q1 = null;
        private String r1 = null;
        private String[] s1 = null;
        private int t1 = -1;
        private int u1 = -16250872;
        private int v1 = 16;
        private boolean w1 = false;
        private int x1 = 25;
        private Drawable y1 = null;
        private int z1 = 0;
        private int A1 = -1;
        private int B1 = -1;
        private int C1 = 25;
        private boolean D1 = false;
        private ArrayList E1 = null;
        private s0 F1 = null;

        public Builder addCustomPrivacyAlertView(View view) {
            this.n1 = view;
            return this;
        }

        public Builder addCustomView(View view, boolean z, boolean z2, ShanYanCustomInterface shanYanCustomInterface) {
            if (view == null) {
                return this;
            }
            if (this.E1 == null) {
                this.E1 = new ArrayList();
            }
            r0 r0Var = new r0();
            r0Var.f1997a = z;
            r0Var.b = z2;
            r0Var.c = view;
            r0Var.d = shanYanCustomInterface;
            this.E1.add(r0Var);
            return this;
        }

        public ShanYanUIConfig build() {
            return new ShanYanUIConfig(this);
        }

        public Builder setActivityTranslateAnim(String str, String str2) {
            this.o1 = str;
            this.p1 = str2;
            return this;
        }

        public Builder setAppPrivacyColor(int i, int i2) {
            this.Q0 = i;
            this.R0 = i2;
            return this;
        }

        public Builder setAppPrivacyOne(String str, String str2) {
            if (AbstractC0600f.b(str) && AbstractC0600f.b(str2)) {
                this.O0.add(new ConfigPrivacyBean(str, str2));
            }
            return this;
        }

        public Builder setAppPrivacyThree(String str, String str2) {
            if (AbstractC0600f.b(str) && AbstractC0600f.b(str2)) {
                this.O0.add(new ConfigPrivacyBean(str, str2));
            }
            return this;
        }

        public Builder setAppPrivacyTwo(String str, String str2) {
            if (AbstractC0600f.b(str) && AbstractC0600f.b(str2)) {
                this.O0.add(new ConfigPrivacyBean(str, str2));
            }
            return this;
        }

        public Builder setAuthBGImgPath(Drawable drawable) {
            this.f2013a = drawable;
            return this;
        }

        public Builder setAuthBgGifPath(String str) {
            this.b = str;
            return this;
        }

        public Builder setAuthBgVideoPath(String str) {
            this.c = str;
            return this;
        }

        public Builder setAuthFlagSecureEnable(boolean z) {
            this.j = z;
            return this;
        }

        public Builder setAuthNavHidden(boolean z) {
            this.z = z;
            return this;
        }

        public Builder setAuthNavTransparent(boolean z) {
            this.x = z;
            return this;
        }

        public Builder setBackNavigationEnabled(boolean z) {
            this.v0 = z;
            return this;
        }

        public Builder setBackPressedAvailable(boolean z) {
            this.q = z;
            return this;
        }

        public Builder setCheckBoxHidden(boolean z) {
            this.B0 = z;
            return this;
        }

        public Builder setCheckBoxMargin(int i, int i2, int i3, int i4) {
            this.W0 = i;
            this.Y0 = i2;
            this.X0 = i3;
            this.Z0 = i4;
            return this;
        }

        public Builder setCheckBoxTipDisable(boolean z) {
            this.z0 = z;
            return this;
        }

        public Builder setCheckBoxWH(int i, int i2) {
            this.U0 = i;
            this.V0 = i2;
            return this;
        }

        public Builder setCheckedImgPath(Drawable drawable) {
            this.t0 = drawable;
            return this;
        }

        public Builder setCustomPrivacyAlertViewAutoShow(boolean z) {
            this.A0 = z;
            return this;
        }

        public Builder setDialogDimAmount(float f) {
            this.l1 = f;
            return this;
        }

        public Builder setDialogTheme(boolean z, int i, int i2, int i3, int i4, boolean z2) {
            this.f1 = z;
            this.h1 = i;
            this.i1 = i2;
            this.j1 = i3;
            this.k1 = i4;
            this.g1 = z2;
            return this;
        }

        public Builder setFitsSystemWindows(boolean z) {
            this.i = z;
            return this;
        }

        public Builder setFullScreen(boolean z) {
            this.o = z;
            return this;
        }

        public Builder setLightColor(boolean z) {
            this.f = z;
            return this;
        }

        public Builder setLoadingView(View view) {
            this.m1 = view;
            return this;
        }

        public Builder setLogBtnBackgroundColor(int i) {
            this.m0 = i;
            return this;
        }

        public Builder setLogBtnHeight(int i) {
            this.p0 = i;
            return this;
        }

        public Builder setLogBtnImgPath(Drawable drawable) {
            this.n0 = drawable;
            return this;
        }

        public Builder setLogBtnOffsetBottomY(int i) {
            this.j0 = i;
            return this;
        }

        public Builder setLogBtnOffsetX(int i) {
            this.k0 = i;
            return this;
        }

        public Builder setLogBtnOffsetY(int i) {
            this.i0 = i;
            return this;
        }

        public Builder setLogBtnText(String str) {
            this.g0 = str;
            return this;
        }

        public Builder setLogBtnTextBold(boolean z) {
            this.h0 = z;
            return this;
        }

        public Builder setLogBtnTextColor(int i) {
            this.l0 = i;
            return this;
        }

        public Builder setLogBtnTextSize(int i) {
            this.f0 = i;
            return this;
        }

        public Builder setLogBtnWidth(int i) {
            this.o0 = i;
            return this;
        }

        public Builder setLogoHeight(int i) {
            this.M = i;
            return this;
        }

        public Builder setLogoHidden(boolean z) {
            this.N = z;
            return this;
        }

        public Builder setLogoImgPath(Drawable drawable) {
            this.O = drawable;
            return this;
        }

        public Builder setLogoOffsetBottomY(int i) {
            this.J = i;
            return this;
        }

        public Builder setLogoOffsetX(int i) {
            this.K = i;
            return this;
        }

        public Builder setLogoOffsetY(int i) {
            this.I = i;
            return this;
        }

        public Builder setLogoWidth(int i) {
            this.L = i;
            return this;
        }

        public Builder setMorePrivacy(List<ConfigPrivacyBean> list) {
            this.O0 = list;
            return this;
        }

        public Builder setNavColor(int i) {
            this.s = i;
            return this;
        }

        public Builder setNavReturnBtnHeight(int i) {
            this.G = i;
            return this;
        }

        public Builder setNavReturnBtnOffsetRightX(int i) {
            this.F = i;
            return this;
        }

        public Builder setNavReturnBtnOffsetX(int i) {
            this.D = i;
            return this;
        }

        public Builder setNavReturnBtnOffsetY(int i) {
            this.E = i;
            return this;
        }

        public Builder setNavReturnBtnWidth(int i) {
            this.B = i;
            return this;
        }

        public Builder setNavReturnImgHidden(boolean z) {
            this.H = z;
            return this;
        }

        public Builder setNavReturnImgPath(Drawable drawable) {
            this.C = drawable;
            return this;
        }

        public Builder setNavText(String str) {
            this.t = str;
            return this;
        }

        public Builder setNavTextBold(boolean z) {
            this.w = z;
            return this;
        }

        public Builder setNavTextColor(int i) {
            this.u = i;
            return this;
        }

        public Builder setNavTextSize(int i) {
            this.v = i;
            return this;
        }

        public Builder setNumFieldHeight(int i) {
            this.P = i;
            return this;
        }

        public Builder setNumFieldOffsetBottomY(int i) {
            this.U = i;
            return this;
        }

        public Builder setNumFieldOffsetX(int i) {
            this.V = i;
            return this;
        }

        public Builder setNumFieldOffsetY(int i) {
            this.T = i;
            return this;
        }

        public Builder setNumFieldWidth(int i) {
            this.Q = i;
            return this;
        }

        public Builder setNumberBold(boolean z) {
            this.S = z;
            return this;
        }

        public Builder setNumberColor(int i) {
            this.R = i;
            return this;
        }

        public Builder setNumberSize(int i) {
            this.W = i;
            return this;
        }

        public Builder setOperatorInfo(List<OperatorInfoBean> list) {
            this.P0 = list;
            return this;
        }

        public Builder setOperatorPrivacyAtLast(boolean z) {
            this.r0 = z;
            return this;
        }

        public Builder setPrivacyActivityEnabled(boolean z) {
            this.x0 = z;
            return this;
        }

        public Builder setPrivacyActivityTranslateAnim(String str, String str2) {
            this.q1 = str;
            this.r1 = str2;
            return this;
        }

        public Builder setPrivacyBackNavigationEnabled(boolean z) {
            this.w0 = z;
            return this;
        }

        public Builder setPrivacyCustomToast(Toast toast) {
            this.d1 = toast;
            return this;
        }

        public Builder setPrivacyCustomToastText(String str) {
            this.e1 = str;
            return this;
        }

        public Builder setPrivacyFlagSecureEnable(boolean z) {
            this.k = z;
            return this;
        }

        public Builder setPrivacyFullScreen(boolean z) {
            this.p = z;
            return this;
        }

        public Builder setPrivacyGravityHorizontalCenter(boolean z) {
            this.H0 = z;
            return this;
        }

        public Builder setPrivacyLightColor(boolean z) {
            this.g = z;
            return this;
        }

        public Builder setPrivacyNameUnderline(boolean z) {
            this.y0 = z;
            return this;
        }

        public Builder setPrivacyNavColor(int i) {
            this.t1 = i;
            return this;
        }

        public Builder setPrivacyNavHidden(boolean z) {
            this.A = z;
            return this;
        }

        public Builder setPrivacyNavReturnBtnHeight(int i) {
            this.C1 = i;
            return this;
        }

        public Builder setPrivacyNavReturnBtnOffsetRightX(int i) {
            this.B1 = i;
            return this;
        }

        public Builder setPrivacyNavReturnBtnOffsetX(int i) {
            this.z1 = i;
            return this;
        }

        public Builder setPrivacyNavReturnBtnOffsetY(int i) {
            this.A1 = i;
            return this;
        }

        public Builder setPrivacyNavReturnBtnWidth(int i) {
            this.x1 = i;
            return this;
        }

        public Builder setPrivacyNavReturnImgHidden(boolean z) {
            this.D1 = z;
            return this;
        }

        public Builder setPrivacyNavReturnImgPath(Drawable drawable) {
            this.y1 = drawable;
            return this;
        }

        public Builder setPrivacyNavTextBold(boolean z) {
            this.w1 = z;
            return this;
        }

        public Builder setPrivacyNavTextColor(int i) {
            this.u1 = i;
            return this;
        }

        public Builder setPrivacyNavTextSize(int i) {
            this.v1 = i;
            return this;
        }

        public Builder setPrivacyNavTransparent(boolean z) {
            this.y = z;
            return this;
        }

        public Builder setPrivacyOffsetBottomY(int i) {
            this.D0 = i;
            return this;
        }

        public Builder setPrivacyOffsetGravityLeft(boolean z) {
            this.G0 = z;
            return this;
        }

        public Builder setPrivacyOffsetX(int i) {
            this.F0 = i;
            return this;
        }

        public Builder setPrivacyOffsetY(int i) {
            this.C0 = i;
            return this;
        }

        public Builder setPrivacySmhHidden(boolean z) {
            this.c1 = z;
            return this;
        }

        public Builder setPrivacyState(boolean z) {
            this.u0 = z;
            return this;
        }

        public Builder setPrivacyStatusBarColor(int i) {
            this.e = i;
            return this;
        }

        public Builder setPrivacyStatusBarHidden(boolean z) {
            this.l = z;
            return this;
        }

        public Builder setPrivacyText(String str, String str2, String str3, String str4, String str5) {
            this.I0 = str;
            this.J0 = str2;
            this.K0 = str3;
            this.L0 = str4;
            this.M0 = str5;
            try {
                List list = this.O0;
                if (list != null) {
                    int size = list.size();
                    if (this.r0) {
                        if (size > 0) {
                            ((ConfigPrivacyBean) this.O0.get(0)).setMidStr(str2);
                        }
                        if (size > 1) {
                            ((ConfigPrivacyBean) this.O0.get(1)).setMidStr(str3);
                        }
                        if (size > 2) {
                            ((ConfigPrivacyBean) this.O0.get(2)).setMidStr(str4);
                        }
                    } else {
                        if (size > 0) {
                            ((ConfigPrivacyBean) this.O0.get(0)).setMidStr(str3);
                        }
                        if (size > 1) {
                            ((ConfigPrivacyBean) this.O0.get(1)).setMidStr(str4);
                        }
                    }
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
            return this;
        }

        public Builder setPrivacyTextBold(boolean z) {
            this.E0 = z;
            return this;
        }

        public Builder setPrivacyTextLineSpacing(float f, float f2) {
            this.S0 = f;
            this.T0 = f2;
            return this;
        }

        public Builder setPrivacyTextSize(int i) {
            this.N0 = i;
            return this;
        }

        public Builder setPrivacyTitleArray(String[] strArr) {
            this.s1 = strArr;
            return this;
        }

        public Builder setPrivacyVirtualKeyTransparent(boolean z) {
            this.n = z;
            return this;
        }

        public Builder setPrivacyWidth(int i) {
            this.q0 = i;
            return this;
        }

        public Builder setRelativeCustomView(View view, boolean z, int i, int i2, int i3, int i4, ShanYanCustomInterface shanYanCustomInterface) {
            if (view == null) {
                return this;
            }
            if (this.F1 == null) {
                this.F1 = new s0();
            }
            s0 s0Var = this.F1;
            s0Var.f1999a = z;
            s0Var.b = i;
            s0Var.c = i2;
            s0Var.d = i3;
            s0Var.e = i4;
            s0Var.f = view;
            s0Var.g = shanYanCustomInterface;
            return this;
        }

        public Builder setSloganHidden(boolean z) {
            this.e0 = z;
            return this;
        }

        public Builder setSloganOffsetBottomY(int i) {
            this.Z = i;
            return this;
        }

        public Builder setSloganOffsetX(int i) {
            this.a0 = i;
            return this;
        }

        public Builder setSloganOffsetY(int i) {
            this.Y = i;
            return this;
        }

        public Builder setSloganTextBold(boolean z) {
            this.c0 = z;
            return this;
        }

        public Builder setSloganTextColor(int i) {
            this.b0 = i;
            return this;
        }

        public Builder setSloganTextSize(int i) {
            this.d0 = i;
            return this;
        }

        public Builder setStatusBarColor(int i) {
            this.d = i;
            return this;
        }

        public Builder setStatusBarHidden(boolean z) {
            this.h = z;
            return this;
        }

        public Builder setTextSizeIsdp(boolean z) {
            this.X = z;
            return this;
        }

        public Builder setUncheckedImgPath(Drawable drawable) {
            this.s0 = drawable;
            return this;
        }

        public Builder setViewPortEnabled(boolean z) {
            this.r = z;
            return this;
        }

        public Builder setVirtualKeyTransparent(boolean z) {
            this.m = z;
            return this;
        }

        public Builder setcheckBoxOffsetXY(int i, int i2) {
            this.a1 = i;
            this.b1 = i2;
            return this;
        }
    }

    public Drawable getAuthBGImgPath() {
        return this.c;
    }

    public String getAuthBgGifPath() {
        return this.d;
    }

    public String getAuthBgVideoPath() {
        return this.e;
    }

    public int getCbLeft() {
        return this.a1;
    }

    public int getCbMarginBottom() {
        return this.Z0;
    }

    public int getCbMarginLeft() {
        return this.W0;
    }

    public int getCbMarginRigth() {
        return this.X0;
    }

    public int getCbMarginTop() {
        return this.Y0;
    }

    public int getCbTop() {
        return this.b1;
    }

    public int getCheckboxHeight() {
        return this.V0;
    }

    public int getCheckboxWidth() {
        return this.U0;
    }

    public Drawable getCheckedImgPath() {
        return this.t0;
    }

    public int getClauseBaseColor() {
        return this.Q0;
    }

    public int getClauseColor() {
        return this.R0;
    }

    public View getCustomPrivacyAlertView() {
        return this.n1;
    }

    public ArrayList<r0> getCustomViews() {
        return this.F1;
    }

    public float getDialogDimAmount() {
        return this.l1;
    }

    public int getDialogHeight() {
        return this.i1;
    }

    public int getDialogWidth() {
        return this.h1;
    }

    public int getDialogX() {
        return this.j1;
    }

    public int getDialogY() {
        return this.k1;
    }

    public String getEnterAnim() {
        return this.o1;
    }

    public String getExitAnim() {
        return this.p1;
    }

    public View getLoadingView() {
        return this.m1;
    }

    public int getLogBtnBackgroundColor() {
        return this.m0;
    }

    public Drawable getLogBtnBackgroundPath() {
        return this.n0;
    }

    public int getLogBtnHeight() {
        return this.p0;
    }

    public int getLogBtnOffsetBottomY() {
        return this.j0;
    }

    public int getLogBtnOffsetX() {
        return this.k0;
    }

    public int getLogBtnOffsetY() {
        return this.i0;
    }

    public String getLogBtnText() {
        return this.g0;
    }

    public int getLogBtnTextColor() {
        return this.l0;
    }

    public int getLogBtnTextSize() {
        return this.f0;
    }

    public int getLogBtnWidth() {
        return this.o0;
    }

    public int getLogoHeight() {
        return this.M;
    }

    public Drawable getLogoImgPath() {
        return this.O;
    }

    public int getLogoOffsetBottomY() {
        return this.J;
    }

    public int getLogoOffsetX() {
        return this.K;
    }

    public int getLogoOffsetY() {
        return this.I;
    }

    public int getLogoWidth() {
        return this.L;
    }

    public List<ConfigPrivacyBean> getMorePrivacy() {
        return this.O0;
    }

    public int getNavColor() {
        return this.s;
    }

    public int getNavReturnBtnOffsetRightX() {
        return this.G;
    }

    public int getNavReturnBtnOffsetX() {
        return this.E;
    }

    public int getNavReturnBtnOffsetY() {
        return this.F;
    }

    public Drawable getNavReturnImgPath() {
        return this.D;
    }

    public String getNavText() {
        return this.t;
    }

    public int getNavTextColor() {
        return this.u;
    }

    public int getNavTextSize() {
        return this.v;
    }

    public int getNumFieldHeight() {
        return this.P;
    }

    public int getNumFieldOffsetBottomY() {
        return this.U;
    }

    public int getNumFieldOffsetX() {
        return this.V;
    }

    public int getNumFieldOffsetY() {
        return this.T;
    }

    public int getNumFieldWidth() {
        return this.Q;
    }

    public int getNumberColor() {
        return this.R;
    }

    public int getNumberSize() {
        return this.W;
    }

    public List<OperatorInfoBean> getOperatorInfo() {
        return this.P0;
    }

    public Toast getPrivacyCustomToast() {
        return this.d1;
    }

    public String getPrivacyCustomToastText() {
        return this.e1;
    }

    public String getPrivacyEnterAnim() {
        return this.q1;
    }

    public String getPrivacyExitAnim() {
        return this.r1;
    }

    public int getPrivacyNavColor() {
        return this.t1;
    }

    public int getPrivacyNavReturnBtnOffsetRightX() {
        return this.B1;
    }

    public int getPrivacyNavReturnBtnOffsetX() {
        return this.z1;
    }

    public int getPrivacyNavReturnBtnOffsetY() {
        return this.A1;
    }

    public Drawable getPrivacyNavReturnImgPath() {
        return this.y1;
    }

    public int getPrivacyNavTextColor() {
        return this.u1;
    }

    public int getPrivacyNavTextSize() {
        return this.v1;
    }

    public int getPrivacyOffsetBottomY() {
        return this.D0;
    }

    public int getPrivacyOffsetX() {
        return this.F0;
    }

    public int getPrivacyOffsetY() {
        return this.C0;
    }

    public int getPrivacyReturnBtnHeight() {
        return this.C1;
    }

    public int getPrivacyReturnBtnWidth() {
        return this.x1;
    }

    public int getPrivacyStatusBarColor() {
        return this.h;
    }

    public String getPrivacyTextEnd() {
        return this.M0;
    }

    public String getPrivacyTextHead() {
        return this.I0;
    }

    public float getPrivacyTextLineSpacingAdd() {
        return this.T0;
    }

    public float getPrivacyTextLineSpacingMult() {
        return this.S0;
    }

    public String getPrivacyTextMidOne() {
        return this.J0;
    }

    public String getPrivacyTextMidThree() {
        return this.L0;
    }

    public String getPrivacyTextMidTwo() {
        return this.K0;
    }

    public int getPrivacyTextSize() {
        return this.N0;
    }

    public String[] getPrivacyTitleArray() {
        return this.s1;
    }

    public int getPrivacyWidth() {
        return this.q0;
    }

    public s0 getRelativeCustomView() {
        return this.E1;
    }

    public int getReturnBtnHeight() {
        return this.C;
    }

    public int getReturnBtnWidth() {
        return this.B;
    }

    public int getSloganOffsetBottomY() {
        return this.Z;
    }

    public int getSloganOffsetX() {
        return this.a0;
    }

    public int getSloganOffsetY() {
        return this.Y;
    }

    public int getSloganTextColor() {
        return this.b0;
    }

    public int getSloganTextSize() {
        return this.d0;
    }

    public int getStatusBarColor() {
        return this.g;
    }

    public Drawable getUncheckedImgPath() {
        return this.s0;
    }

    public boolean isAuthFlagSecureEnable() {
        return this.f2012a;
    }

    public boolean isAuthNavHidden() {
        return this.z;
    }

    public boolean isAuthNavTransparent() {
        return this.x;
    }

    public boolean isBackNavigationEnabled() {
        return this.v0;
    }

    public boolean isBackPressedAvailable() {
        return this.q;
    }

    public boolean isCheckBoxHidden() {
        return this.B0;
    }

    public boolean isCustomPrivacyAlertViewAutoShow() {
        return this.A0;
    }

    public boolean isDialogBottom() {
        return this.g1;
    }

    public boolean isDialogTheme() {
        return this.f1;
    }

    public boolean isFitsSystemWindows() {
        return this.f;
    }

    public boolean isFullScreen() {
        return this.o;
    }

    public boolean isLightColor() {
        return this.i;
    }

    public boolean isLogBtnTextBold() {
        return this.h0;
    }

    public boolean isLogoHidden() {
        return this.N;
    }

    public boolean isNavReturnImgHidden() {
        return this.H;
    }

    public boolean isNavTextBold() {
        return this.w;
    }

    public boolean isNumberBold() {
        return this.S;
    }

    public boolean isOperatorPrivacyAtLast() {
        return this.r0;
    }

    public boolean isPrivacyActivityEnabled() {
        return this.x0;
    }

    public boolean isPrivacyBackNavigationEnabled() {
        return this.w0;
    }

    public boolean isPrivacyFlagSecureEnable() {
        return this.b;
    }

    public boolean isPrivacyFullScreen() {
        return this.p;
    }

    public boolean isPrivacyGravityHorizontalCenter() {
        return this.H0;
    }

    public boolean isPrivacyLightColor() {
        return this.j;
    }

    public boolean isPrivacyNameUnderline() {
        return this.y0;
    }

    public boolean isPrivacyNavHidden() {
        return this.A;
    }

    public boolean isPrivacyNavReturnImgHidden() {
        return this.D1;
    }

    public boolean isPrivacyNavTextBold() {
        return this.w1;
    }

    public boolean isPrivacyNavTransparent() {
        return this.y;
    }

    public boolean isPrivacyOffsetGravityLeft() {
        return this.G0;
    }

    public boolean isPrivacySmhHidden() {
        return this.c1;
    }

    public boolean isPrivacyState() {
        return this.u0;
    }

    public boolean isPrivacyStatusBarHidden() {
        return this.l;
    }

    public boolean isPrivacyTextBold() {
        return this.E0;
    }

    public boolean isPrivacyToastHidden() {
        return this.z0;
    }

    public boolean isPrivacyVirtualKeyTransparent() {
        return this.n;
    }

    public boolean isSloganHidden() {
        return this.e0;
    }

    public boolean isSloganTextBold() {
        return this.c0;
    }

    public boolean isStatusBarHidden() {
        return this.k;
    }

    public boolean isTextSizeIsdp() {
        return this.X;
    }

    public boolean isViewPortEnabled() {
        return this.r;
    }

    public boolean isVirtualKeyTransparent() {
        return this.m;
    }

    public void remove() {
        try {
            x0.a(this.m1);
            this.m1 = null;
            x0.a(this.n1);
            this.n1 = null;
            s0 s0Var = this.E1;
            if (s0Var != null) {
                x0.a(s0Var.f);
                this.E1.f = null;
            }
            ArrayList arrayList = this.F1;
            if (arrayList != null) {
                arrayList.clear();
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public String toString() {
        return "ShanYanUIConfig{authBGImgPath=" + (this.c == null) + ", authBgGifPath='" + this.d + "', authBgVideoPath='" + this.e + "', isFitsSystemWindows=" + this.f + ", statusBarColor=" + this.g + ", privacyStatusBarColor=" + this.h + ", isLightColor=" + this.i + ", isPrivacyLightColor=" + this.j + ", isStatusBarHidden=" + this.k + ", isPrivacyStatusBarHidden=" + this.l + ", isVirtualKeyTransparent=" + this.m + ", isPrivacyVirtualKeyTransparent=" + this.n + ", isFullScreen=" + this.o + ", isPrivacyFullScreen=" + this.p + ", isBackPressedAvailable=" + this.q + ", isViewPortEnabled=" + this.r + ", navColor=" + this.s + ", navText='" + this.t + "', navTextColor=" + this.u + ", navTextSize=" + this.v + ", isNavTextBold=" + this.w + ", authNavTransparent=" + this.x + ", privacyNavTransparent=" + this.y + ", authNavHidden=" + this.z + ", privacyNavHidden=" + this.A + ", returnBtnWidth=" + this.B + ", returnBtnHeight=" + this.C + ", navReturnImgPath=" + (this.D == null) + ", navReturnBtnOffsetX=" + this.E + ", navReturnBtnOffsetY=" + this.F + ", navReturnBtnOffsetRightX=" + this.G + ", navReturnImgHidden=" + this.H + ", logoOffsetY=" + this.I + ", logoOffsetBottomY=" + this.J + ", logoOffsetX=" + this.K + ", logoWidth=" + this.L + ", logoHeight=" + this.M + ", logoHidden=" + this.N + ", LogoImgPath=" + (this.O == null) + ", numFieldHeight=" + this.P + ", numFieldWidth=" + this.Q + ", numberColor=" + this.R + ", isNumberBold=" + this.S + ", numFieldOffsetY=" + this.T + ", numFieldOffsetBottomY=" + this.U + ", numFieldOffsetX=" + this.V + ", numberSize=" + this.W + ", textSizeIsdp=" + this.X + ", sloganOffsetY=" + this.Y + ", sloganOffsetBottomY=" + this.Z + ", sloganOffsetX=" + this.a0 + ", sloganTextColor=" + this.b0 + ", isSloganTextBold=" + this.c0 + ", sloganTextSize=" + this.d0 + ", sloganHidden=" + this.e0 + ", logBtnTextSize=" + this.f0 + ", logBtnText='" + this.g0 + "', isLogBtnTextBold=" + this.h0 + ", logBtnOffsetY=" + this.i0 + ", logBtnOffsetBottomY=" + this.j0 + ", logBtnOffsetX=" + this.k0 + ", logBtnTextColor=" + this.l0 + ", logBtnBackgroundColor=" + this.m0 + ", logBtnBackgroundPath=" + (this.n0 == null) + ", logBtnWidth=" + this.o0 + ", logBtnHeight=" + this.p0 + ", privacyWidth=" + this.q0 + ", operatorPrivacyAtLast=" + this.r0 + ", uncheckedImgPath=" + (this.s0 == null) + ", checkedImgPath=" + (this.t0 == null) + ", privacyState=" + this.u0 + ", isBackNavigationEnabled=" + this.v0 + ", isPrivacyBackNavigationEnabled=" + this.w0 + ", privacyActivityEnabled=" + this.x0 + ", privacyNameUnderline=" + this.y0 + ", privacyToastHidden=" + this.z0 + ", customPrivacyAlertViewAutoShow=" + this.A0 + ", checkBoxHidden=" + this.B0 + ", privacyOffsetY=" + this.C0 + ", privacyOffsetBottomY=" + this.D0 + ", isPrivacyTextBold=" + this.E0 + ", privacyOffsetX=" + this.F0 + ", privacyOffsetGravityLeft=" + this.G0 + ", privacyGravityHorizontalCenter=" + this.H0 + ", privacyTextHead='" + this.I0 + "', privacyTextMidOne='" + this.J0 + "', privacyTextMidTwo='" + this.K0 + "', privacyTextMidThree='" + this.L0 + "', privacyTextEnd='" + this.M0 + "', privacyTextSize=" + this.N0 + ", morePrivacy=" + (this.O0 == null) + ", operatorInfo=" + (this.P0 == null) + ", CLAUSE_BASE_COLOR=" + this.Q0 + ", CLAUSE_COLOR=" + this.R0 + ", textLineSpacingMult=" + this.S0 + ", textLineSpacingAdd=" + this.T0 + ", checkboxWidth=" + this.U0 + ", checkboxHeight=" + this.V0 + ", cbMarginLeft=" + this.W0 + ", cbMarginRigth=" + this.X0 + ", cbMarginTop=" + this.Y0 + ", cbMarginBottom=" + this.Z0 + ", cbLeft=" + this.a1 + ", cbTop=" + this.b1 + ", privacySmhHidden=" + this.c1 + ", privacyCustomToast=" + (this.d1 == null) + ", toastText='" + this.e1 + "', isDialogTheme=" + this.f1 + ", isDialogBottom=" + this.g1 + ", dialogWidth=" + this.h1 + ", dialogHeight=" + this.i1 + ", dialogX=" + this.j1 + ", dialogY=" + this.k1 + ", dialogDimAmount=" + this.l1 + ", loadingView=" + (this.m1 == null) + ", customPrivacyAlertView=" + (this.n1 == null) + ", enterAnim='" + this.o1 + "', exitAnim='" + this.p1 + "', privacyEnterAnim='" + this.q1 + "', privacyExitAnim='" + this.r1 + "', privacyTitleArray=" + Arrays.toString(this.s1) + ", privacyNavColor=" + this.t1 + ", privacyNavTextColor=" + this.u1 + ", privacyNavTextSize=" + this.v1 + ", isPrivacyNavTextBold=" + this.w1 + ", privacyReturnBtnWidth=" + this.x1 + ", privacyNavReturnImgPath=" + (this.y1 == null) + ", privacyNavReturnBtnOffsetX=" + this.z1 + ", privacyNavReturnBtnOffsetY=" + this.A1 + ", privacyNavReturnBtnOffsetRightX=" + this.B1 + ", privacyReturnBtnHeight=" + this.C1 + ", privacyNavReturnImgHidden=" + this.D1 + ", relativeCustomView=" + (this.E1 == null) + ", customViews=" + (this.F1 == null) + '}';
    }

    private ShanYanUIConfig(Builder builder) {
        this.c = builder.f2013a;
        this.d = builder.b;
        this.e = builder.c;
        this.g = builder.d;
        this.h = builder.e;
        this.i = builder.f;
        this.j = builder.g;
        this.k = builder.h;
        this.f = builder.i;
        this.f2012a = builder.j;
        this.b = builder.k;
        this.l = builder.l;
        this.m = builder.m;
        this.n = builder.n;
        this.o = builder.o;
        this.p = builder.p;
        this.q = builder.q;
        this.r = builder.r;
        this.s = builder.s;
        this.t = builder.t;
        this.u = builder.u;
        this.v = builder.v;
        this.w = builder.w;
        this.x = builder.x;
        this.y = builder.y;
        this.z = builder.z;
        this.A = builder.A;
        this.B = builder.B;
        this.D = builder.C;
        this.E = builder.D;
        this.F = builder.E;
        this.G = builder.F;
        this.C = builder.G;
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
        this.a0 = builder.a0;
        this.b0 = builder.b0;
        this.c0 = builder.c0;
        this.d0 = builder.d0;
        this.e0 = builder.e0;
        this.f0 = builder.f0;
        this.g0 = builder.g0;
        this.h0 = builder.h0;
        this.i0 = builder.i0;
        this.j0 = builder.j0;
        this.k0 = builder.k0;
        this.l0 = builder.l0;
        this.m0 = builder.m0;
        this.n0 = builder.n0;
        this.o0 = builder.o0;
        this.p0 = builder.p0;
        this.q0 = builder.q0;
        this.s0 = builder.s0;
        this.r0 = builder.r0;
        this.t0 = builder.t0;
        this.u0 = builder.u0;
        this.v0 = builder.v0;
        this.w0 = builder.w0;
        this.x0 = builder.x0;
        this.y0 = builder.y0;
        this.z0 = builder.z0;
        this.A0 = builder.A0;
        this.B0 = builder.B0;
        this.C0 = builder.C0;
        this.D0 = builder.D0;
        this.E0 = builder.E0;
        this.F0 = builder.F0;
        this.G0 = builder.G0;
        this.H0 = builder.H0;
        this.I0 = builder.I0;
        this.J0 = builder.J0;
        this.K0 = builder.K0;
        this.L0 = builder.L0;
        this.M0 = builder.M0;
        this.N0 = builder.N0;
        this.O0 = builder.O0;
        this.P0 = builder.P0;
        this.Q0 = builder.Q0;
        this.R0 = builder.R0;
        this.T0 = builder.S0;
        this.S0 = builder.T0;
        this.U0 = builder.U0;
        this.V0 = builder.V0;
        this.W0 = builder.W0;
        this.X0 = builder.X0;
        this.Y0 = builder.Y0;
        this.Z0 = builder.Z0;
        this.a1 = builder.a1;
        this.b1 = builder.b1;
        this.c1 = builder.c1;
        this.d1 = builder.d1;
        this.e1 = builder.e1;
        this.f1 = builder.f1;
        this.g1 = builder.g1;
        this.h1 = builder.h1;
        this.i1 = builder.i1;
        this.j1 = builder.j1;
        this.k1 = builder.k1;
        this.l1 = builder.l1;
        this.m1 = builder.m1;
        this.n1 = builder.n1;
        this.o1 = builder.o1;
        this.p1 = builder.p1;
        this.q1 = builder.q1;
        this.r1 = builder.r1;
        this.s1 = builder.s1;
        this.t1 = builder.t1;
        this.u1 = builder.u1;
        this.v1 = builder.v1;
        this.w1 = builder.w1;
        this.x1 = builder.x1;
        this.y1 = builder.y1;
        this.z1 = builder.z1;
        this.A1 = builder.A1;
        this.B1 = builder.B1;
        this.C1 = builder.C1;
        this.D1 = builder.D1;
        this.F1 = builder.E1;
        this.E1 = builder.F1;
    }
}
