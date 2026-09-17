package com.cmic.gen.sdk.view;

import android.R;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Point;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.text.Spannable;
import android.text.SpannableString;
import android.text.TextUtils;
import android.text.method.LinkMovementMethod;
import android.text.style.StyleSpan;
import android.util.DisplayMetrics;
import android.view.KeyEvent;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.view.WindowManager;
import android.view.animation.AnimationUtils;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.widget.Toast;
import androidx.core.view.InputDeviceCompat;
import com.cmic.gen.sdk.auth.GenAuthnHelper;
import com.cmic.gen.sdk.auth.GenTokenListener;
import com.cmic.gen.sdk.f.f;
import com.cmic.gen.sdk.f.i;
import com.cmic.gen.sdk.f.l;
import com.cmic.gen.sdk.f.o;
import com.cmic.gen.sdk.f.r;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.lang.ref.WeakReference;
import java.net.URL;
import java.util.ArrayList;
import java.util.Iterator;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public class GenLoginAuthActivity extends Activity implements View.OnClickListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected static final String f2138a = "GenLoginAuthActivity";
    private String A;
    private String C;
    private GenAuthThemeConfig E;
    private int F;
    private int G;
    private boolean H;
    private ImageView I;
    private Dialog J;
    RelativeLayout b;
    private Handler c;
    private Context d;
    private RelativeLayout e;
    private d f;
    private d g;
    private d h;
    private d i;
    private d j;
    private ArrayList<d> k;
    private ArrayList<String> l;
    private String[] m;
    private String[] n;
    private com.cmic.gen.sdk.a o;
    private com.cmic.gen.sdk.auth.a p;
    private CheckBox r;
    private RelativeLayout s;
    private RelativeLayout t;
    private GenTokenListener x;
    private RelativeLayout z;
    private String q = "";
    private long u = 0;
    private int v = 0;
    private a w = null;
    private boolean y = true;
    private String B = "";
    private String D = "";

    static /* synthetic */ int a(GenLoginAuthActivity genLoginAuthActivity, int i) {
        int i2 = genLoginAuthActivity.v + i;
        genLoginAuthActivity.v = i2;
        return i2;
    }

    @Override // android.app.Activity
    protected void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        if (bundle != null) {
            try {
                finish();
            } catch (Exception e) {
                if (this.o == null) {
                    this.o = new com.cmic.gen.sdk.a(0);
                }
                this.o.a().f2094a.add(e);
                com.cmic.gen.sdk.f.c.a(f2138a, e.toString());
                e.printStackTrace();
                a("200025", "发生未知错误", this.o, null);
                return;
            }
        }
        this.d = this;
        GenAuthThemeConfig authThemeConfig = GenAuthnHelper.getInstance((Context) this).getAuthThemeConfig();
        this.E = authThemeConfig;
        if (authThemeConfig != null) {
            if (authThemeConfig.getThemeId() != -1) {
                setTheme(this.E.getThemeId());
            }
            if (this.E.getAuthPageActIn() != null && this.E.getActivityOut() != null) {
                overridePendingTransition(com.cmic.gen.sdk.view.c.c(this, this.E.getAuthPageActIn()), com.cmic.gen.sdk.view.c.c(this, this.E.getActivityOut()));
            }
        }
        com.cmic.gen.sdk.d.a.a("authPageIn");
        this.u = System.currentTimeMillis();
        this.p = com.cmic.gen.sdk.auth.a.a(this);
        d();
        f();
    }

    @Override // android.app.Activity
    protected void onResume() {
        super.onResume();
        try {
            RelativeLayout relativeLayout = this.e;
            if (relativeLayout != null) {
                relativeLayout.postDelayed(new Runnable() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.1
                    @Override // java.lang.Runnable
                    public void run() {
                        GenLoginAuthActivity.this.setVisible(true);
                        int[] iArr = new int[2];
                        GenLoginAuthActivity.this.t.getLocationOnScreen(iArr);
                        int i = iArr[1];
                        com.cmic.gen.sdk.f.c.b(GenLoginAuthActivity.f2138a, "mPhoneLayout" + iArr[1]);
                        GenLoginAuthActivity.this.e.getLocationOnScreen(iArr);
                        int i2 = iArr[1];
                        com.cmic.gen.sdk.f.c.b(GenLoginAuthActivity.f2138a, "mPhoneLayout" + iArr[1]);
                        GenLoginAuthActivity.this.s.getLocationOnScreen(iArr);
                        int i3 = iArr[1];
                        com.cmic.gen.sdk.f.c.b(GenLoginAuthActivity.f2138a, "mPhoneLayout" + iArr[1]);
                        if (i <= i2 && i <= i3) {
                            GenLoginAuthActivity.this.t.setFocusableInTouchMode(true);
                            GenLoginAuthActivity.this.t.requestFocus();
                        } else if (i2 < i3) {
                            GenLoginAuthActivity.this.e.setFocusableInTouchMode(true);
                            GenLoginAuthActivity.this.e.requestFocus();
                        } else {
                            GenLoginAuthActivity.this.r.setFocusableInTouchMode(true);
                            GenLoginAuthActivity.this.r.requestFocus();
                        }
                    }
                }, 500L);
            }
            com.cmic.gen.sdk.a aVar = this.o;
            if (aVar != null) {
                aVar.a("loginMethod", "loginAuth");
            }
            GenAuthnHelper.getInstance((Context) this).loginPageInCallBack("200087");
        } catch (Exception e) {
            e.printStackTrace();
            this.o.a().f2094a.add(e);
            a("200025", "发生未知错误", this.o, null);
        }
    }

    private void d() {
        com.cmic.gen.sdk.a aVarD = f.d(getIntent().getStringExtra("traceId"));
        this.o = aVarD;
        if (aVarD == null) {
            this.o = new com.cmic.gen.sdk.a(0);
        }
        this.x = f.c(this.o.b("traceId", ""));
        getWindowManager().getDefaultDisplay().getMetrics(new DisplayMetrics());
        this.c = new Handler(getMainLooper());
        this.w = new a(this);
        this.q = this.o.b("securityphone");
        String str = f2138a;
        com.cmic.gen.sdk.f.c.b(str, "mSecurityPhone value is " + this.q);
        String strB = this.o.b("operatortype", "");
        com.cmic.gen.sdk.f.c.b(str, "operator value is " + strB);
        String strB2 = l.b("operator1", "");
        String strB3 = l.b("operator2", "");
        String strB4 = l.b("operator3", "");
        String strB5 = l.b("operator4", "");
        if (!TextUtils.isEmpty(strB2) && !TextUtils.isEmpty(strB3) && !TextUtils.isEmpty(strB4) && !TextUtils.isEmpty(strB5)) {
            com.cmic.gen.sdk.f.c.b(str, "读取接口协议配置缓存 ");
            try {
                JSONObject jSONObject = new JSONObject(l.b("operator" + strB, ""));
                Iterator<String> itKeys = jSONObject.keys();
                this.m = new String[3];
                String[] strArr = new String[3];
                for (int i = 0; itKeys.hasNext() && i < 3; i++) {
                    String next = itKeys.next();
                    String str2 = f2138a;
                    com.cmic.gen.sdk.f.c.b(str2, "读取接口协议 " + jSONObject.optString(next).split("\\^")[0]);
                    com.cmic.gen.sdk.f.c.b(str2, "读取接口协议url " + jSONObject.optString(next).split("\\^")[1]);
                    this.m[i] = jSONObject.optString(next).split("\\^")[0];
                    strArr[i] = jSONObject.optString(next).split("\\^")[1];
                }
                this.A = this.m[this.E.getAppLanguageType()];
                this.B = strArr[this.E.getAppLanguageType()];
            } catch (Exception e) {
                e.printStackTrace();
                a(strB);
            }
        } else {
            a(strB);
        }
        int privacyDialogThemeId = this.E.getPrivacyDialogThemeId();
        if (privacyDialogThemeId == -1) {
            privacyDialogThemeId = 16973840;
        }
        d dVar = new d(this.d, privacyDialogThemeId, this.A, this.B);
        this.f = dVar;
        dVar.setOnKeyListener(new DialogInterface.OnKeyListener() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.6
            @Override // android.content.DialogInterface.OnKeyListener
            public boolean onKey(DialogInterface dialogInterface, int i2, KeyEvent keyEvent) {
                if (i2 == 4 && keyEvent.getAction() == 1 && keyEvent.getRepeatCount() == 0) {
                    GenLoginAuthActivity.this.f.b();
                }
                return true;
            }
        });
        this.k = new ArrayList<>();
        this.l = new ArrayList<>();
        if (!TextUtils.isEmpty(this.E.getClauseUrl())) {
            d dVar2 = new d(this.d, privacyDialogThemeId, this.E.getClauseName(), this.E.getClauseUrl());
            this.g = dVar2;
            dVar2.setOnKeyListener(new DialogInterface.OnKeyListener() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.7
                @Override // android.content.DialogInterface.OnKeyListener
                public boolean onKey(DialogInterface dialogInterface, int i2, KeyEvent keyEvent) {
                    if (i2 == 4 && keyEvent.getAction() == 1 && keyEvent.getRepeatCount() == 0) {
                        GenLoginAuthActivity.this.g.b();
                    }
                    return true;
                }
            });
            this.k.add(this.g);
            this.l.add(this.E.getClauseName());
        }
        if (!TextUtils.isEmpty(this.E.getClauseUrl2())) {
            d dVar3 = new d(this.d, privacyDialogThemeId, this.E.getClauseName2(), this.E.getClauseUrl2());
            this.h = dVar3;
            dVar3.setOnKeyListener(new DialogInterface.OnKeyListener() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.8
                @Override // android.content.DialogInterface.OnKeyListener
                public boolean onKey(DialogInterface dialogInterface, int i2, KeyEvent keyEvent) {
                    if (i2 == 4 && keyEvent.getAction() == 1 && keyEvent.getRepeatCount() == 0) {
                        GenLoginAuthActivity.this.h.b();
                    }
                    return true;
                }
            });
            this.k.add(this.h);
            this.l.add(this.E.getClauseName2());
        }
        if (!TextUtils.isEmpty(this.E.getClauseUrl3())) {
            d dVar4 = new d(this.d, privacyDialogThemeId, this.E.getClauseName3(), this.E.getClauseUrl3());
            this.i = dVar4;
            dVar4.setOnKeyListener(new DialogInterface.OnKeyListener() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.9
                @Override // android.content.DialogInterface.OnKeyListener
                public boolean onKey(DialogInterface dialogInterface, int i2, KeyEvent keyEvent) {
                    if (i2 == 4 && keyEvent.getAction() == 1 && keyEvent.getRepeatCount() == 0) {
                        GenLoginAuthActivity.this.i.b();
                    }
                    return true;
                }
            });
            this.k.add(this.i);
            this.l.add(this.E.getClauseName3());
        }
        if (!TextUtils.isEmpty(this.E.getClauseUrl4())) {
            d dVar5 = new d(this.d, R.style.Theme.Translucent.NoTitleBar, this.E.getClauseName4(), this.E.getClauseUrl4());
            this.j = dVar5;
            dVar5.setOnKeyListener(new DialogInterface.OnKeyListener() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.10
                @Override // android.content.DialogInterface.OnKeyListener
                public boolean onKey(DialogInterface dialogInterface, int i2, KeyEvent keyEvent) {
                    if (i2 == 4 && keyEvent.getAction() == 1 && keyEvent.getRepeatCount() == 0) {
                        GenLoginAuthActivity.this.j.b();
                    }
                    return true;
                }
            });
            this.k.add(this.j);
            this.l.add(this.E.getClauseName4());
        }
        l();
        if (this.E.isPrivacyBookSymbol()) {
            for (int i2 = 0; i2 < this.l.size(); i2++) {
                String str3 = String.format("《%s》", this.l.get(i2));
                this.C = this.C.replaceFirst(this.l.get(i2), str3);
                this.l.set(i2, str3);
            }
        }
        com.cmic.gen.sdk.view.b.a().a(new com.cmic.gen.sdk.view.b.a() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.11
            @Override // com.cmic.gen.sdk.view.b.a
            public void a() {
                GenLoginAuthActivity.this.c.removeCallbacksAndMessages(null);
                if (GenLoginAuthActivity.this.f != null && GenLoginAuthActivity.this.f.isShowing()) {
                    GenLoginAuthActivity.this.f.dismiss();
                }
                if (GenLoginAuthActivity.this.g != null && GenLoginAuthActivity.this.g.isShowing()) {
                    GenLoginAuthActivity.this.g.dismiss();
                }
                GenLoginAuthActivity.this.a(true);
            }
        });
    }

    public void a(String str) {
        if (this.E.getAppLanguageType() == 1) {
            this.m = com.cmic.gen.sdk.c.b;
            this.n = com.cmic.gen.sdk.c.e;
            this.D = com.cmic.gen.sdk.c.h[1];
        } else if (this.E.getAppLanguageType() == 2) {
            this.m = com.cmic.gen.sdk.c.c;
            this.n = com.cmic.gen.sdk.c.f;
            this.D = com.cmic.gen.sdk.c.h[2];
        } else {
            this.m = com.cmic.gen.sdk.c.f2066a;
            this.n = com.cmic.gen.sdk.c.d;
            this.D = com.cmic.gen.sdk.c.h[0];
        }
        if (str.equals("1")) {
            this.A = this.m[0];
            this.B = this.n[0];
        } else if (str.equals("3")) {
            this.A = this.m[1];
            this.B = this.n[1];
        } else if (str.equals("2")) {
            this.A = this.m[2];
            this.B = this.n[2];
        } else {
            this.A = this.m[3];
            this.B = this.n[3];
        }
    }

    private void e() {
        int privacyMarginLeft;
        RelativeLayout.LayoutParams layoutParams = (RelativeLayout.LayoutParams) this.t.getLayoutParams();
        if (this.E.getNumFieldOffsetY() > 0 || this.E.getNumFieldOffsetY_B() < 0) {
            int iMakeMeasureSpec = View.MeasureSpec.makeMeasureSpec(0, 0);
            this.t.measure(iMakeMeasureSpec, iMakeMeasureSpec);
            String str = f2138a;
            com.cmic.gen.sdk.f.c.b(str, "mPhoneLayout.getMeasuredHeight()=" + this.t.getMeasuredHeight());
            if (this.E.getNumFieldOffsetY() > 0 && (this.F - this.t.getMeasuredHeight()) - e.a(this.d, this.E.getNumFieldOffsetY()) > 0) {
                com.cmic.gen.sdk.f.c.b(str, "numberField_top");
                layoutParams.addRule(10, -1);
                layoutParams.setMargins(0, e.a(this.d, this.E.getNumFieldOffsetY()), 0, 0);
            } else {
                layoutParams.addRule(12, -1);
            }
        } else if (this.E.getNumFieldOffsetY_B() > 0 && (this.F - this.t.getMeasuredHeight()) - e.a(this.d, this.E.getNumFieldOffsetY_B()) > 0) {
            com.cmic.gen.sdk.f.c.b(f2138a, "numberField_bottom");
            layoutParams.addRule(12, -1);
            layoutParams.setMargins(0, 0, 0, e.a(this.d, this.E.getNumFieldOffsetY_B()));
        } else {
            layoutParams.addRule(10, -1);
        }
        this.t.setLayoutParams(layoutParams);
        RelativeLayout.LayoutParams layoutParams2 = (RelativeLayout.LayoutParams) this.e.getLayoutParams();
        int iMax = Math.max(this.E.getLogBtnMarginLeft(), 0);
        int iMax2 = Math.max(this.E.getLogBtnMarginRight(), 0);
        if (this.E.getLogBtnOffsetY() > 0 || this.E.getLogBtnOffsetY_B() < 0) {
            if (this.E.getLogBtnOffsetY() > 0 && this.F - e.a(this.d, this.E.getLogBtnHeight() + this.E.getLogBtnOffsetY()) > 0) {
                com.cmic.gen.sdk.f.c.b(f2138a, "logBtn_top");
                layoutParams2.addRule(10, -1);
                layoutParams2.setMargins(e.a(this.d, iMax), e.a(this.d, this.E.getLogBtnOffsetY()), e.a(this.d, iMax2), 0);
            } else {
                layoutParams2.addRule(12, -1);
                layoutParams2.setMargins(e.a(this.d, iMax), 0, e.a(this.d, iMax2), 0);
            }
        } else if (this.E.getLogBtnOffsetY_B() > 0 && this.F - e.a(this.d, this.E.getLogBtnHeight() + this.E.getLogBtnOffsetY_B()) > 0) {
            com.cmic.gen.sdk.f.c.b(f2138a, "logBtn_bottom");
            layoutParams2.addRule(12, -1);
            layoutParams2.setMargins(e.a(this.d, iMax), 0, e.a(this.d, iMax2), e.a(this.d, this.E.getLogBtnOffsetY_B()));
        } else {
            layoutParams2.addRule(10, -1);
            layoutParams2.setMargins(e.a(this.d, iMax), 0, e.a(this.d, iMax2), 0);
        }
        this.e.setLayoutParams(layoutParams2);
        RelativeLayout.LayoutParams layoutParams3 = (RelativeLayout.LayoutParams) this.s.getLayoutParams();
        if (this.E.getPrivacyMarginLeft() >= 0) {
            privacyMarginLeft = this.E.getCheckedImgWidth() > 30 ? this.E.getPrivacyMarginLeft() : this.E.getPrivacyMarginLeft() - (30 - this.E.getCheckedImgWidth());
        } else {
            privacyMarginLeft = this.E.getCheckedImgWidth() > 30 ? 0 : -(30 - this.E.getCheckedImgWidth());
        }
        int iMax3 = Math.max(this.E.getPrivacyMarginRight(), 0);
        int iMakeMeasureSpec2 = View.MeasureSpec.makeMeasureSpec(0, 0);
        this.s.measure(iMakeMeasureSpec2, iMakeMeasureSpec2);
        if (this.E.getPrivacyOffsetY() > 0 || this.E.getPrivacyOffsetY_B() < 0) {
            if (this.E.getPrivacyOffsetY() > 0 && (this.F - this.s.getMeasuredHeight()) - e.a(this.d, this.E.getPrivacyOffsetY()) > 0) {
                com.cmic.gen.sdk.f.c.b(f2138a, "privacy_top = " + this.s.getMeasuredHeight());
                layoutParams3.addRule(10, -1);
                layoutParams3.setMargins(e.a(this.d, privacyMarginLeft), e.a(this.d, this.E.getPrivacyOffsetY()), e.a(this.d, iMax3), 0);
            } else {
                com.cmic.gen.sdk.f.c.b(f2138a, "privacy_bottom=" + privacyMarginLeft);
                layoutParams3.addRule(12, -1);
                layoutParams3.setMargins(e.a(this.d, privacyMarginLeft), 0, e.a(this.d, iMax3), 0);
            }
        } else if (this.E.getPrivacyOffsetY_B() > 0 && (this.F - this.s.getMeasuredHeight()) - e.a(this.d, this.E.getPrivacyOffsetY_B()) > 0) {
            com.cmic.gen.sdk.f.c.b(f2138a, "privacy_bottom=" + this.s.getMeasuredHeight());
            layoutParams3.addRule(12, -1);
            layoutParams3.setMargins(e.a(this.d, privacyMarginLeft), 0, e.a(this.d, iMax3), e.a(this.d, this.E.getPrivacyOffsetY_B()));
        } else {
            layoutParams3.addRule(10, -1);
            layoutParams3.setMargins(e.a(this.d, privacyMarginLeft), 0, e.a(this.d, iMax3), 0);
            com.cmic.gen.sdk.f.c.b(f2138a, "privacy_top");
        }
        this.s.setLayoutParams(layoutParams3);
    }

    private void f() {
        getWindow().addFlags(67108864);
        getWindow().addFlags(134217728);
        if (this.E.getStatusBarColor() != 0) {
            getWindow().addFlags(Integer.MIN_VALUE);
            getWindow().clearFlags(67108864);
            getWindow().setStatusBarColor(this.E.getStatusBarColor());
            getWindow().setNavigationBarColor(this.E.getStatusBarColor());
        }
        int i = this.E.isLightColor() ? 8192 : 0;
        if (this.E.isNavHidden()) {
            i |= InputDeviceCompat.SOURCE_TOUCHSCREEN;
        }
        getWindow().getDecorView().setSystemUiVisibility(i);
        RelativeLayout relativeLayout = new RelativeLayout(this);
        this.b = relativeLayout;
        relativeLayout.setLayoutParams(new RelativeLayout.LayoutParams(-1, -1));
        View contentView = this.E.getContentView();
        if (contentView != null) {
            ViewParent parent = contentView.getParent();
            if (parent != null) {
                ((ViewGroup) parent).removeView(contentView);
            }
            this.b.addView(contentView);
        } else if (this.E.getLayoutResID() != -1) {
            getLayoutInflater().inflate(this.E.getLayoutResID(), this.b);
        }
        setContentView(this.b);
        int requestedOrientation = getRequestedOrientation();
        this.F = e.b(this.d);
        int iA = e.a(this.d);
        this.G = iA;
        if ((requestedOrientation == 1 && iA > this.F) || (requestedOrientation == 0 && iA < this.F)) {
            this.G = this.F;
            this.F = iA;
        }
        com.cmic.gen.sdk.f.c.b(f2138a, "orientation = " + requestedOrientation + "--screenWidth = " + this.G + "--screenHeight = " + this.F);
        WindowManager.LayoutParams attributes = getWindow().getAttributes();
        if (this.E.getWindowWidth() != 0) {
            getWindow().getWindowManager().getDefaultDisplay().getMetrics(new DisplayMetrics());
            getWindowManager().getDefaultDisplay().getSize(new Point());
            attributes.width = e.a(this.d, this.E.getWindowWidth());
            attributes.height = e.a(this.d, this.E.getWindowHeight());
            this.G = attributes.width;
            this.F = attributes.height;
            attributes.x = e.a(this.d, this.E.getWindowX());
            if (this.E.getWindowBottom() == 1) {
                getWindow().setGravity(80);
            } else {
                attributes.y = e.a(this.d, this.E.getWindowY());
            }
            getWindow().setAttributes(attributes);
        }
        this.b.setFitsSystemWindows(this.E.isFitsSystemWindows());
        this.b.setClipToPadding(true);
        try {
            i();
            this.b.addView(this.t);
            this.b.addView(j());
            this.b.addView(k());
            e();
            h();
            a(this.b);
            this.e.setOnClickListener(this);
            this.z.setOnClickListener(this);
            this.r.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.12
                @Override // android.widget.CompoundButton.OnCheckedChangeListener
                public void onCheckedChanged(CompoundButton compoundButton, boolean z) {
                    if (GenLoginAuthActivity.this.E.getGenCheckedChangeListener() != null) {
                        GenLoginAuthActivity.this.E.getGenCheckedChangeListener().onCheckedChanged(z);
                    }
                    if (z) {
                        if (GenLoginAuthActivity.this.I != null) {
                            GenLoginAuthActivity.this.I.setVisibility(0);
                        }
                        GenLoginAuthActivity.this.e.setEnabled(true);
                        try {
                            CheckBox checkBox = GenLoginAuthActivity.this.r;
                            GenLoginAuthActivity genLoginAuthActivity = GenLoginAuthActivity.this;
                            checkBox.setBackgroundResource(com.cmic.gen.sdk.view.c.b(genLoginAuthActivity, genLoginAuthActivity.E.getCheckedImgPath()));
                        } catch (Exception unused) {
                            GenLoginAuthActivity.this.r.setBackgroundResource(com.cmic.gen.sdk.view.c.b(GenLoginAuthActivity.this, "umcsdk_check_image"));
                        }
                        GenLoginAuthActivity.this.r.setContentDescription("复选框 已勾选 " + GenLoginAuthActivity.this.C);
                        return;
                    }
                    if (GenLoginAuthActivity.this.I != null) {
                        GenLoginAuthActivity.this.I.setVisibility(4);
                    }
                    GenLoginAuthActivity.this.e.setEnabled(GenLoginAuthActivity.this.p());
                    try {
                        CheckBox checkBox2 = GenLoginAuthActivity.this.r;
                        GenLoginAuthActivity genLoginAuthActivity2 = GenLoginAuthActivity.this;
                        checkBox2.setBackgroundResource(com.cmic.gen.sdk.view.c.b(genLoginAuthActivity2, genLoginAuthActivity2.E.getUncheckedImgPath()));
                    } catch (Exception unused2) {
                        GenLoginAuthActivity.this.r.setBackgroundResource(com.cmic.gen.sdk.view.c.b(GenLoginAuthActivity.this, "umcsdk_uncheck_image"));
                    }
                    GenLoginAuthActivity.this.r.setContentDescription("复选框 请双击勾选 " + GenLoginAuthActivity.this.C);
                }
            });
            m();
            try {
                if (this.E.isPrivacyState()) {
                    ImageView imageView = this.I;
                    if (imageView != null) {
                        imageView.setVisibility(0);
                    }
                    this.r.setChecked(true);
                    this.r.setBackgroundResource(com.cmic.gen.sdk.view.c.b(this, this.E.getCheckedImgPath()));
                    this.e.setEnabled(true);
                    this.r.setContentDescription("复选框 已勾选 " + this.C);
                    return;
                }
                this.r.setChecked(false);
                ImageView imageView2 = this.I;
                if (imageView2 != null) {
                    imageView2.setVisibility(4);
                }
                this.e.setEnabled(p());
                this.r.setBackgroundResource(com.cmic.gen.sdk.view.c.b(this, this.E.getUncheckedImgPath()));
                this.r.setContentDescription("复选框 请双击勾选 " + this.C);
            } catch (Exception unused) {
                this.r.setChecked(false);
            }
        } catch (Exception e) {
            com.cmic.gen.sdk.d.c.b.add(e);
            e.printStackTrace();
            com.cmic.gen.sdk.f.c.a(f2138a, e.toString());
            a("200040", "UI资源加载异常", this.o, null);
        }
    }

    /* JADX WARN: Code duplicated, block: B:16:0x009f  */
    /* JADX WARN: Code duplicated, block: B:18:0x00b0  */
    /* JADX WARN: Code duplicated, block: B:19:0x00bb  */
    /* JADX WARN: Code duplicated, block: B:20:0x00bf  */
    /* JADX WARN: Code duplicated, block: B:22:0x00c7  */
    /* JADX WARN: Code duplicated, block: B:24:0x00d8  */
    /* JADX WARN: Code duplicated, block: B:25:0x00e9  */
    /* JADX WARN: Code duplicated, block: B:26:0x00ed  */
    private void a(RelativeLayout relativeLayout) {
        int iA;
        String str;
        int provideTextOffsetY;
        int provideTextOffsetY_B;
        float f;
        int iA2;
        int iA3;
        float f2;
        String strB = this.o.b("operatortype", "");
        if (!"4".equals(strB)) {
            com.cmic.gen.sdk.f.c.b(f2138a, "operator = " + strB);
            return;
        }
        TextView textViewG = g();
        int iMakeMeasureSpec = View.MeasureSpec.makeMeasureSpec(0, 0);
        textViewG.measure(iMakeMeasureSpec, iMakeMeasureSpec);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-2, -2);
        int provideTextOffsetX = this.E.getProvideTextOffsetX();
        if (provideTextOffsetX < 0) {
            layoutParams.addRule(14);
        } else {
            float f3 = provideTextOffsetX;
            if ((this.G - textViewG.getMeasuredWidth()) - e.a(this.d, f3) > 0) {
                iA = e.a(this.d, f3);
            } else {
                com.cmic.gen.sdk.f.c.b(f2138a, "RelativeLayout.ALIGN_PARENT_RIGHT");
                layoutParams.addRule(11);
            }
            str = f2138a;
            com.cmic.gen.sdk.f.c.a(str, "provideTextView size：" + textViewG.getMeasuredWidth() + " " + textViewG.getMeasuredHeight());
            provideTextOffsetY = this.E.getProvideTextOffsetY();
            if (provideTextOffsetY > 0) {
                f2 = provideTextOffsetY;
                if ((this.F - textViewG.getMeasuredHeight()) - e.a(this.d, f2) > 0) {
                    layoutParams.addRule(10, -1);
                    iA3 = e.a(this.d, f2);
                    iA2 = 0;
                } else {
                    layoutParams.addRule(12, -1);
                    iA3 = 0;
                    iA2 = 0;
                }
            } else {
                provideTextOffsetY_B = this.E.getProvideTextOffsetY_B();
                if (provideTextOffsetY_B > 0) {
                    f = provideTextOffsetY_B;
                    if ((this.F - textViewG.getMeasuredHeight()) - e.a(this.d, f) > 0) {
                        com.cmic.gen.sdk.f.c.b(str, "numberField_bottom");
                        layoutParams.addRule(12, -1);
                        iA2 = e.a(this.d, f);
                        iA3 = 0;
                    } else {
                        layoutParams.addRule(10, -1);
                    }
                } else {
                    layoutParams.addRule(12, -1);
                }
                iA3 = 0;
                iA2 = 0;
            }
            layoutParams.setMargins(iA, iA3, 0, iA2);
            relativeLayout.addView(textViewG, layoutParams);
        }
        iA = 0;
        str = f2138a;
        com.cmic.gen.sdk.f.c.a(str, "provideTextView size：" + textViewG.getMeasuredWidth() + " " + textViewG.getMeasuredHeight());
        provideTextOffsetY = this.E.getProvideTextOffsetY();
        if (provideTextOffsetY > 0) {
            f2 = provideTextOffsetY;
            if ((this.F - textViewG.getMeasuredHeight()) - e.a(this.d, f2) > 0) {
                layoutParams.addRule(10, -1);
                iA3 = e.a(this.d, f2);
                iA2 = 0;
            } else {
                layoutParams.addRule(12, -1);
                iA3 = 0;
                iA2 = 0;
            }
        } else {
            provideTextOffsetY_B = this.E.getProvideTextOffsetY_B();
            if (provideTextOffsetY_B > 0) {
                f = provideTextOffsetY_B;
                if ((this.F - textViewG.getMeasuredHeight()) - e.a(this.d, f) > 0) {
                    com.cmic.gen.sdk.f.c.b(str, "numberField_bottom");
                    layoutParams.addRule(12, -1);
                    iA2 = e.a(this.d, f);
                    iA3 = 0;
                } else {
                    layoutParams.addRule(10, -1);
                }
            } else {
                layoutParams.addRule(12, -1);
            }
            iA3 = 0;
            iA2 = 0;
        }
        layoutParams.setMargins(iA, iA3, 0, iA2);
        relativeLayout.addView(textViewG, layoutParams);
    }

    private TextView g() {
        TextView textView = new TextView(this);
        if (this.E.getAppLanguageType() == 1) {
            textView.setText("本頁面由中國移動香港有限公司開發提供");
        } else if (this.E.getAppLanguageType() == 2) {
            textView.setText("Powered by China Mobile Hong Kong Ltd.");
        } else {
            textView.setText("本页面由中国移动香港有限公司开发提供");
        }
        if (this.E.getProvideTextBold()) {
            textView.setTypeface(Typeface.DEFAULT_BOLD);
        }
        try {
            textView.setTextColor(this.E.getProvideTextColor());
        } catch (Exception unused) {
            textView.setTextColor(-13421773);
        }
        try {
            textView.setTextSize(2, this.E.getProvideTextSize());
        } catch (Exception unused2) {
            textView.setTextSize(2, 18.0f);
        }
        return textView;
    }

    private void h() {
        final String strB = l.b("imageUrl", "");
        String strB2 = l.b("displayLogo", "");
        String str = f2138a;
        com.cmic.gen.sdk.f.c.c(str, "logoimgUrl=" + strB);
        com.cmic.gen.sdk.f.c.c(str, "displaylogo=" + strB2);
        com.cmic.gen.sdk.f.c.c(str, "config.isDisplayLogo()=" + this.E.isDisplayLogo());
        if (!TextUtils.isEmpty(strB) && strB2.equals("1") && this.E.isDisplayLogo()) {
            ImageView imageView = new ImageView(this.d);
            this.I = imageView;
            imageView.setVisibility(4);
            o.a(new o.a() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.13
                @Override // com.cmic.gen.sdk.f.o.a
                protected void a() {
                    final Bitmap bitmapDecodeStream;
                    try {
                        File externalFilesDir = GenLoginAuthActivity.this.d.getExternalFilesDir("LogoFile");
                        if (!externalFilesDir.exists()) {
                            com.cmic.gen.sdk.f.c.c(GenLoginAuthActivity.f2138a, "logo文件夹不存在");
                            if (!externalFilesDir.mkdirs()) {
                                com.cmic.gen.sdk.f.c.c(GenLoginAuthActivity.f2138a, "logo文件夹创建失败");
                            }
                        }
                        String absolutePath = new File(externalFilesDir + "/" + com.cmic.gen.sdk.f.d.a(strB)).getAbsolutePath();
                        com.cmic.gen.sdk.f.c.c(GenLoginAuthActivity.f2138a, "logo文件路径" + absolutePath);
                        File file = new File(absolutePath);
                        if (file.isFile() && file.exists()) {
                            com.cmic.gen.sdk.f.c.c(GenLoginAuthActivity.f2138a, "读取本地文件");
                            bitmapDecodeStream = BitmapFactory.decodeFile(absolutePath);
                        } else {
                            com.cmic.gen.sdk.f.c.c(GenLoginAuthActivity.f2138a, "读取网络文件");
                            bitmapDecodeStream = BitmapFactory.decodeStream(new URL(strB).openStream());
                            try {
                                bitmapDecodeStream.compress(Bitmap.CompressFormat.PNG, 100, new FileOutputStream(absolutePath));
                                com.cmic.gen.sdk.f.c.c(GenLoginAuthActivity.f2138a, "保存文件到本地");
                            } catch (Exception e) {
                                e.printStackTrace();
                            }
                        }
                        GenLoginAuthActivity.this.b.post(new Runnable() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.13.1
                            /* JADX WARN: Code duplicated, block: B:15:0x0100  */
                            /* JADX WARN: Code duplicated, block: B:17:0x0118  */
                            /* JADX WARN: Code duplicated, block: B:18:0x0127  */
                            /* JADX WARN: Code duplicated, block: B:19:0x0132 A[DONT_INVERT] */
                            /* JADX WARN: Code duplicated, block: B:20:0x0134  */
                            /* JADX WARN: Code duplicated, block: B:22:0x014d  */
                            /* JADX WARN: Code duplicated, block: B:23:0x015d  */
                            /* JADX WARN: Code duplicated, block: B:25:0x016a  */
                            /* JADX WARN: Code duplicated, block: B:29:0x01b8  */
                            @Override // java.lang.Runnable
                            public void run() {
                                int iA;
                                float f;
                                int height;
                                int i;
                                int iA2;
                                float f2;
                                GenLoginAuthActivity.this.I.setImageBitmap(bitmapDecodeStream);
                                int logoOffsetX = GenLoginAuthActivity.this.E.getLogoOffsetX();
                                int logoOffsetY = GenLoginAuthActivity.this.E.getLogoOffsetY();
                                int logoOffsetY_B = GenLoginAuthActivity.this.E.getLogoOffsetY_B();
                                int iA3 = e.a(GenLoginAuthActivity.this.d, GenLoginAuthActivity.this.E.getLogoWidth());
                                int iA4 = e.a(GenLoginAuthActivity.this.d, GenLoginAuthActivity.this.E.getLogoHeight());
                                RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(iA3, iA4);
                                if (logoOffsetX >= 0) {
                                    float f3 = logoOffsetX;
                                    if ((GenLoginAuthActivity.this.G - iA3) - e.a(GenLoginAuthActivity.this.d, f3) > 0) {
                                        iA = e.a(GenLoginAuthActivity.this.d, f3);
                                    } else {
                                        com.cmic.gen.sdk.f.c.b(GenLoginAuthActivity.f2138a, "logo ALIGN_PARENT_RIGHT");
                                        layoutParams.addRule(11);
                                    }
                                    f = logoOffsetY;
                                    com.cmic.gen.sdk.f.c.b("lyy", GenLoginAuthActivity.this.F + "-" + iA4 + "--" + e.a(GenLoginAuthActivity.this.d, f));
                                    if (logoOffsetY >= 0) {
                                        if (logoOffsetY_B >= 0) {
                                            f2 = logoOffsetY_B;
                                            if ((GenLoginAuthActivity.this.F - iA4) - e.a(GenLoginAuthActivity.this.d, f2) > 0) {
                                                height = e.a(GenLoginAuthActivity.this.d, f2);
                                                layoutParams.addRule(12);
                                            } else {
                                                com.cmic.gen.sdk.f.c.b(GenLoginAuthActivity.f2138a, "logo ALIGN_PARENT_RIGHT");
                                                layoutParams.addRule(10);
                                                iA2 = 0;
                                                i = 0;
                                            }
                                        } else {
                                            com.cmic.gen.sdk.f.c.b(GenLoginAuthActivity.f2138a, "log 默认样式");
                                            layoutParams.addRule(8, 13107);
                                            height = GenLoginAuthActivity.this.t.getHeight();
                                            com.cmic.gen.sdk.f.c.a("bottom", height + "");
                                        }
                                        i = height;
                                        iA2 = 0;
                                    } else if ((GenLoginAuthActivity.this.F - iA4) - e.a(GenLoginAuthActivity.this.d, f) > 0) {
                                        iA2 = e.a(GenLoginAuthActivity.this.d, f);
                                        i = 0;
                                    } else {
                                        com.cmic.gen.sdk.f.c.b(GenLoginAuthActivity.f2138a, "logo ALIGN_PARENT_BOTTOM");
                                        layoutParams.addRule(12);
                                        iA2 = 0;
                                        i = 0;
                                    }
                                    layoutParams.setMargins(iA, iA2, 0, i);
                                    GenLoginAuthActivity.this.I.setLayoutParams(layoutParams);
                                    if (GenLoginAuthActivity.this.E.getLogoScaleType() != null) {
                                        GenLoginAuthActivity.this.I.setScaleType(GenLoginAuthActivity.this.E.getLogoScaleType());
                                    }
                                    GenLoginAuthActivity.this.b.addView(GenLoginAuthActivity.this.I);
                                }
                                if ((GenLoginAuthActivity.this.G - GenLoginAuthActivity.this.t.getRight()) - iA3 >= 0) {
                                    layoutParams.addRule(1, 13107);
                                } else {
                                    layoutParams.addRule(11);
                                }
                                iA = 0;
                                f = logoOffsetY;
                                com.cmic.gen.sdk.f.c.b("lyy", GenLoginAuthActivity.this.F + "-" + iA4 + "--" + e.a(GenLoginAuthActivity.this.d, f));
                                if (logoOffsetY >= 0) {
                                    if (logoOffsetY_B >= 0) {
                                        f2 = logoOffsetY_B;
                                        if ((GenLoginAuthActivity.this.F - iA4) - e.a(GenLoginAuthActivity.this.d, f2) > 0) {
                                            height = e.a(GenLoginAuthActivity.this.d, f2);
                                            layoutParams.addRule(12);
                                        } else {
                                            com.cmic.gen.sdk.f.c.b(GenLoginAuthActivity.f2138a, "logo ALIGN_PARENT_RIGHT");
                                            layoutParams.addRule(10);
                                            iA2 = 0;
                                            i = 0;
                                        }
                                    } else {
                                        com.cmic.gen.sdk.f.c.b(GenLoginAuthActivity.f2138a, "log 默认样式");
                                        layoutParams.addRule(8, 13107);
                                        height = GenLoginAuthActivity.this.t.getHeight();
                                        com.cmic.gen.sdk.f.c.a("bottom", height + "");
                                    }
                                    i = height;
                                    iA2 = 0;
                                } else if ((GenLoginAuthActivity.this.F - iA4) - e.a(GenLoginAuthActivity.this.d, f) > 0) {
                                    iA2 = e.a(GenLoginAuthActivity.this.d, f);
                                    i = 0;
                                } else {
                                    com.cmic.gen.sdk.f.c.b(GenLoginAuthActivity.f2138a, "logo ALIGN_PARENT_BOTTOM");
                                    layoutParams.addRule(12);
                                    iA2 = 0;
                                    i = 0;
                                }
                                layoutParams.setMargins(iA, iA2, 0, i);
                                GenLoginAuthActivity.this.I.setLayoutParams(layoutParams);
                                if (GenLoginAuthActivity.this.E.getLogoScaleType() != null) {
                                    GenLoginAuthActivity.this.I.setScaleType(GenLoginAuthActivity.this.E.getLogoScaleType());
                                }
                                GenLoginAuthActivity.this.b.addView(GenLoginAuthActivity.this.I);
                            }
                        });
                    } catch (IOException e2) {
                        e2.printStackTrace();
                    }
                }
            });
        }
    }

    private void i() {
        RelativeLayout relativeLayout = new RelativeLayout(this);
        this.t = relativeLayout;
        relativeLayout.setId(13107);
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-2, -2);
        this.t.setLayoutParams(layoutParams);
        TextView textView = new TextView(this);
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(-2, -2);
        textView.setGravity(15);
        int numberOffsetX = this.E.getNumberOffsetX();
        if (numberOffsetX == 0) {
            layoutParams.addRule(13);
        } else if (numberOffsetX > 0) {
            float f = numberOffsetX;
            if ((this.G - textView.getWidth()) - e.a(this.d, f) > 0) {
                layoutParams2.setMargins(e.a(this.d, f), 0, 0, 0);
            } else {
                com.cmic.gen.sdk.f.c.b(f2138a, "RelativeLayout.ALIGN_PARENT_RIGHT");
                layoutParams2.addRule(11);
            }
        }
        try {
            textView.setTextSize(2, this.E.getNumberSize());
            textView.setContentDescription(this.q.replace("****", "星星星星").replaceAll("(.{1})", "$1 "));
        } catch (Exception unused) {
            textView.setTextSize(2, 18.0f);
        }
        com.cmic.gen.sdk.f.e.a(textView, this.q);
        if (this.E.isNumberBold()) {
            textView.setTypeface(Typeface.DEFAULT_BOLD);
        }
        textView.setId(30583);
        this.t.addView(textView, layoutParams2);
        try {
            textView.setTextColor(this.E.getNumberColor());
        } catch (Exception unused2) {
            textView.setTextColor(-13421773);
        }
        int iMakeMeasureSpec = View.MeasureSpec.makeMeasureSpec(0, 0);
        this.t.measure(iMakeMeasureSpec, iMakeMeasureSpec);
        com.cmic.gen.sdk.f.c.b(f2138a, "mPhoneLayout.getMeasuredHeight()=" + this.t.getMeasuredHeight());
    }

    private RelativeLayout j() {
        RelativeLayout relativeLayout = new RelativeLayout(this);
        this.e = relativeLayout;
        relativeLayout.setId(17476);
        this.e.setLayoutParams(new RelativeLayout.LayoutParams(e.a(this.d, this.E.getLogBtnWidth()), e.a(this.d, this.E.getLogBtnHeight())));
        TextView textView = new TextView(this);
        textView.setTextSize(2, this.E.getLogBtnTextSize());
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-2, -2);
        layoutParams.addRule(13);
        textView.setLayoutParams(layoutParams);
        if (this.E.isLogBtnTextBold()) {
            textView.setTypeface(Typeface.DEFAULT_BOLD);
        }
        this.e.addView(textView);
        textView.setText(this.E.getLogBtnText());
        try {
            textView.setTextColor(this.E.getLogBtnTextColor());
        } catch (Exception unused) {
            textView.setTextColor(-1);
        }
        try {
            this.e.setBackgroundResource(com.cmic.gen.sdk.view.c.b(this.d, this.E.getLogBtnBackgroundPath()));
        } catch (Exception e) {
            e.printStackTrace();
            this.e.setBackgroundResource(com.cmic.gen.sdk.view.c.b(this.d, "umcsdk_login_btn_bg"));
        }
        return this.e;
    }

    private RelativeLayout k() {
        RelativeLayout relativeLayout = new RelativeLayout(this);
        this.s = relativeLayout;
        relativeLayout.setHorizontalGravity(1);
        this.s.setLayoutParams(new RelativeLayout.LayoutParams(-1, -2));
        int checkedImgWidth = this.E.getCheckedImgWidth();
        RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(e.a(this.d, Math.max(checkedImgWidth, 30)), e.a(this.d, Math.max(this.E.getCheckedImgHeight(), 30)));
        if (this.E.getCheckBoxLocation() == 1) {
            layoutParams.addRule(15, -1);
        }
        RelativeLayout relativeLayout2 = new RelativeLayout(this);
        this.z = relativeLayout2;
        relativeLayout2.setId(34952);
        this.z.setLayoutParams(layoutParams);
        CheckBox checkBox = new CheckBox(this);
        this.r = checkBox;
        checkBox.setChecked(false);
        RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(e.a(this.d, this.E.getCheckedImgWidth()), e.a(this.d, this.E.getCheckedImgHeight()));
        layoutParams2.setMargins(e.a(this.d, checkedImgWidth > 30 ? 0.0f : 30 - checkedImgWidth), 0, 0, 0);
        layoutParams2.addRule(11, -1);
        if (this.E.getCheckBoxLocation() == 1) {
            layoutParams2.addRule(15, -1);
        }
        this.r.setLayoutParams(layoutParams2);
        this.z.addView(this.r);
        this.s.addView(this.z);
        TextView textView = new TextView(this);
        textView.setTextSize(2, this.E.getPrivacyTextSize());
        RelativeLayout.LayoutParams layoutParams3 = new RelativeLayout.LayoutParams(-2, -2);
        layoutParams3.setMargins(e.a(this.d, 5.0f), 0, 0, e.a(this.d, 5.0f));
        layoutParams3.addRule(1, 34952);
        textView.setLayoutParams(layoutParams3);
        this.s.addView(textView);
        textView.setTextColor(this.E.getClauseBaseColor());
        SpannableString spannableStringA = e.a(this, this.C, this.A, this.B, this.f, this.k, this.l);
        Typeface typefaceDefaultFromStyle = Typeface.defaultFromStyle(0);
        for (int i = 0; i < this.C.length(); i++) {
            if (this.C.charAt(i) == 12289) {
                spannableStringA.setSpan(new StyleSpan(typefaceDefaultFromStyle.getStyle()), i, i + 1, 33);
            }
        }
        textView.setText(spannableStringA);
        textView.setLineSpacing(8.0f, 1.0f);
        textView.setIncludeFontPadding(false);
        if (this.E.isPrivacyTextBold()) {
            textView.setTypeface(Typeface.DEFAULT_BOLD);
        }
        if (this.E.isPrivacyTextGravityCenter()) {
            textView.setGravity(17);
        }
        textView.setHighlightColor(getResources().getColor(R.color.transparent));
        if (!this.E.isCheckBoxAccurateClick()) {
            this.s.setOnClickListener(new View.OnClickListener() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.2
                @Override // android.view.View.OnClickListener
                public void onClick(View view) {
                    GenLoginAuthActivity.this.r.setChecked(!GenLoginAuthActivity.this.r.isChecked());
                }
            });
        }
        textView.setMovementMethod(new LinkMovementMethod() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.3
            @Override // android.text.method.LinkMovementMethod, android.text.method.ScrollingMovementMethod, android.text.method.BaseMovementMethod, android.text.method.MovementMethod
            public boolean onTouchEvent(TextView textView2, Spannable spannable, MotionEvent motionEvent) {
                boolean zOnTouchEvent = super.onTouchEvent(textView2, spannable, motionEvent);
                if (!zOnTouchEvent && motionEvent.getAction() == 1) {
                    ViewParent parent = textView2.getParent();
                    if (parent instanceof ViewGroup) {
                        return ((ViewGroup) parent).performClick();
                    }
                }
                return zOnTouchEvent;
            }
        });
        this.r.setButtonDrawable(new ColorDrawable());
        try {
            this.r.setBackgroundResource(com.cmic.gen.sdk.view.c.b(this, this.E.getUncheckedImgPath()));
        } catch (Exception unused) {
            this.r.setBackgroundResource(com.cmic.gen.sdk.view.c.b(this, "umcsdk_uncheck_image"));
        }
        return this.s;
    }

    private String l() {
        this.C = this.E.getPrivacy();
        if (this.E.isPrivacyBookSymbol()) {
            this.A = String.format("《%s》", this.A);
        }
        if (this.C.contains(GenAuthThemeConfig.PLACEHOLDER)) {
            this.C = this.C.replace(GenAuthThemeConfig.PLACEHOLDER, this.A);
        }
        return this.C;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void m() {
        this.e.setClickable(true);
        this.r.setClickable(true);
    }

    private void n() {
        this.e.setClickable(false);
        this.r.setClickable(false);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(boolean z) {
        try {
            com.cmic.gen.sdk.d.a.a("authPageOut");
            a("200020", "登录页面关闭", this.o, null);
        } catch (Exception e) {
            com.cmic.gen.sdk.d.c.b.add(e);
            e.printStackTrace();
        }
    }

    @Override // android.app.Activity, android.view.KeyEvent.Callback
    public boolean onKeyUp(int i, KeyEvent keyEvent) {
        if (i != 4 || keyEvent.isCanceled() || keyEvent.getRepeatCount() != 0) {
            return true;
        }
        if (this.E.getGenBackPressedListener() != null) {
            this.E.getGenBackPressedListener().onBackPressed();
        }
        if (this.E.getWindowWidth() != 0 && !this.E.isBackButton()) {
            return true;
        }
        a(false);
        return true;
    }

    @Override // android.app.Activity
    protected void onDestroy() {
        try {
            this.c.removeCallbacksAndMessages(null);
            com.cmic.gen.sdk.d.a.a("timeOnAuthPage", (System.currentTimeMillis() - this.u) + "");
            if (this.r.isChecked()) {
                com.cmic.gen.sdk.d.a.a("authPrivacyState", "1");
            } else {
                com.cmic.gen.sdk.d.a.a("authPrivacyState", "0");
            }
            com.cmic.gen.sdk.d.a.a(this.d.getApplicationContext(), this.o);
            com.cmic.gen.sdk.d.a.a();
            this.J = null;
            com.cmic.gen.sdk.view.b.a().c();
            this.w.removeCallbacksAndMessages(null);
        } catch (Exception e) {
            com.cmic.gen.sdk.f.c.a(f2138a, "GenLoginAuthActivity clear failed");
            com.cmic.gen.sdk.d.c.b.add(e);
            e.printStackTrace();
        }
        super.onDestroy();
    }

    private class c implements Runnable {
        private com.cmic.gen.sdk.a b;
        private boolean c;

        c(com.cmic.gen.sdk.a aVar) {
            this.b = aVar;
        }

        @Override // java.lang.Runnable
        public void run() {
            if (a(true)) {
                JSONObject jSONObject = new JSONObject();
                try {
                    jSONObject.put("resultCode", "102507");
                    jSONObject.put("resultString", "请求超时");
                } catch (JSONException e) {
                    e.printStackTrace();
                }
                GenLoginAuthActivity.this.y = false;
                com.cmic.gen.sdk.d.a.a("authClickFailed");
                GenLoginAuthActivity.this.w.sendEmptyMessage(1);
                long jB = this.b.b("loginTime", 0L);
                if (jB != 0) {
                    this.b.a("loginTime", System.currentTimeMillis() - jB);
                }
                GenLoginAuthActivity.this.a("102507", "请求超时", this.b, jSONObject);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public synchronized boolean a(boolean z) {
            boolean z2;
            z2 = this.c;
            this.c = z;
            return !z2;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void o() {
        try {
            if (this.v >= 5) {
                Toast.makeText(this.d, "网络不稳定,请返回重试其他登录方式", 1).show();
                this.e.setClickable(true);
                return;
            }
            StackTraceElement[] stackTrace = Thread.currentThread().getStackTrace();
            StringBuilder sb = new StringBuilder();
            for (StackTraceElement stackTraceElement : stackTrace) {
                com.cmic.gen.sdk.f.c.a("stack", stackTraceElement.getClassName());
                String className = stackTraceElement.getClassName();
                if (!TextUtils.isEmpty(className) && className.contains("com.cmic.gen.sdk.activity") && !sb.toString().contains(className)) {
                    sb.append(className).append(com.alipay.sdk.m.y.l.b);
                }
            }
            this.o.a("loginTime", System.currentTimeMillis());
            String strB = this.o.b("traceId", "");
            if (!TextUtils.isEmpty(strB) && f.a(strB)) {
                String strC = r.c();
                this.o.a("traceId", strC);
                f.a(strC, this.x);
            }
            b();
            n();
            c cVar = new c(this.o);
            this.c.postDelayed(cVar, GenAuthnHelper.getInstance((Context) this).getOverTime());
            o.a(new b(this, cVar));
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str, String str2, com.cmic.gen.sdk.a aVar, JSONObject jSONObject) {
        try {
            if (this.c == null) {
                this.c = new Handler(getMainLooper());
                this.w = new a(this);
            }
            this.c.removeCallbacksAndMessages(null);
            if ("103000".equals(str)) {
                if (GenAuthnHelper.getInstance((Context) this) == null || f.c(aVar.b("traceId")) == null) {
                    return;
                }
                aVar.a("keepListener", true);
                GenAuthnHelper.getInstance((Context) this).callBackResult(str, str2, aVar, jSONObject);
                return;
            }
            if ("200020".equals(str)) {
                if (GenAuthnHelper.getInstance((Context) this) != null) {
                    if (f.c(aVar.b("traceId")) != null) {
                        GenAuthnHelper.getInstance((Context) this).callBackResult(str, str2, aVar, jSONObject);
                        a();
                        return;
                    } else {
                        a();
                        return;
                    }
                }
                return;
            }
            aVar.a("keepListener", true);
            GenAuthnHelper.getInstance((Context) this).callBackResult(str, str2, aVar, jSONObject);
        } catch (Exception e) {
            com.cmic.gen.sdk.f.c.a(f2138a, "CallbackResult:未知错误");
            e.printStackTrace();
        }
    }

    public void a() {
        this.c.removeCallbacksAndMessages(null);
        d dVar = this.f;
        if (dVar != null && dVar.isShowing()) {
            this.f.dismiss();
        }
        d dVar2 = this.g;
        if (dVar2 != null && dVar2.isShowing()) {
            this.g.dismiss();
        }
        c();
        this.J = null;
        RelativeLayout relativeLayout = this.s;
        if (relativeLayout != null) {
            relativeLayout.clearAnimation();
        }
        com.cmic.gen.sdk.view.b.a().f2159a = 0;
        finish();
        if (this.E.getAuthPageActOut() == null || this.E.getActivityIn() == null) {
            return;
        }
        overridePendingTransition(com.cmic.gen.sdk.view.c.c(this, this.E.getActivityIn()), com.cmic.gen.sdk.view.c.c(this, this.E.getAuthPageActOut()));
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        try {
            int id = view.getId();
            if (id != 17476) {
                if (id == 26214) {
                    a(false);
                    return;
                } else {
                    if (id != 34952) {
                        return;
                    }
                    if (this.r.isChecked()) {
                        this.r.setChecked(false);
                        return;
                    } else {
                        this.r.setChecked(true);
                        return;
                    }
                }
            }
            if (!this.r.isChecked()) {
                if (this.E.getGenAuthLoginListener() != null) {
                    com.cmic.gen.sdk.d.a.a("PrivacyNotSelectedCustom");
                    this.E.getGenAuthLoginListener().onAuthLoginListener(this.d, new AuthLoginCallBack() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.4
                        @Override // com.cmic.gen.sdk.view.AuthLoginCallBack
                        public void onAuthLoginCallBack(boolean z) {
                            if (z) {
                                GenLoginAuthActivity.this.r.setChecked(true);
                                GenLoginAuthActivity.a(GenLoginAuthActivity.this, 1);
                                GenLoginAuthActivity.this.o();
                            }
                        }
                    });
                    return;
                }
                if (this.E.getPrivacyAnimation() != null) {
                    com.cmic.gen.sdk.d.a.a("PrivacyNotSelectedShake");
                    Context context = this.d;
                    this.s.startAnimation(AnimationUtils.loadAnimation(context, com.cmic.gen.sdk.view.c.c(context, this.E.getPrivacyAnimation())));
                    return;
                }
                if (this.E.getGenCheckBoxListener() != null) {
                    com.cmic.gen.sdk.d.a.a("PrivacyNotSelectedPopup");
                    this.E.getGenCheckBoxListener().onLoginClick(this.d, null);
                    return;
                } else if (!TextUtils.isEmpty(this.E.getCheckTipText())) {
                    com.cmic.gen.sdk.d.a.a("PrivacyNotSelectedToast");
                    Toast.makeText(this.d, this.E.getCheckTipText(), 1).show();
                    return;
                }
            }
            this.v++;
            o();
        } catch (Exception e) {
            com.cmic.gen.sdk.d.c.b.add(e);
            e.printStackTrace();
        }
    }

    private static class a extends Handler {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        WeakReference<GenLoginAuthActivity> f2153a;

        a(GenLoginAuthActivity genLoginAuthActivity) {
            this.f2153a = new WeakReference<>(genLoginAuthActivity);
        }

        @Override // android.os.Handler
        public void handleMessage(Message message) {
            try {
                a(message);
            } catch (Exception e) {
                com.cmic.gen.sdk.d.c.b.add(e);
                e.printStackTrace();
            }
        }

        private void a(Message message) {
            GenLoginAuthActivity genLoginAuthActivity = this.f2153a.get();
            if (genLoginAuthActivity == null || message.what != 1) {
                return;
            }
            genLoginAuthActivity.c();
            genLoginAuthActivity.m();
        }
    }

    public void b() {
        com.cmic.gen.sdk.f.c.a(f2138a, "loginClickStart");
        try {
            this.H = true;
            if (this.E.getGenLoginClickListener() != null) {
                this.E.getGenLoginClickListener().onLoginClickStart(this.d, null);
            } else {
                Dialog dialog = this.J;
                if (dialog != null) {
                    dialog.show();
                    return;
                }
                AlertDialog alertDialogCreate = new AlertDialog.Builder(this).create();
                this.J = alertDialogCreate;
                alertDialogCreate.setCancelable(false);
                this.J.setCanceledOnTouchOutside(false);
                this.J.setOnKeyListener(new DialogInterface.OnKeyListener() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.5
                    @Override // android.content.DialogInterface.OnKeyListener
                    public boolean onKey(DialogInterface dialogInterface, int i, KeyEvent keyEvent) {
                        return i == 4;
                    }
                });
                RelativeLayout relativeLayout = new RelativeLayout(this.J.getContext());
                relativeLayout.setLayoutParams(new RelativeLayout.LayoutParams(-1, -2));
                ImageView imageView = new ImageView(this.J.getContext());
                imageView.setImageResource(com.cmic.gen.sdk.view.c.b(this.d, "umcsdk_dialog_loading"));
                RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(80, 80);
                layoutParams.addRule(13, -1);
                relativeLayout.addView(imageView, layoutParams);
                if (this.J.getWindow() != null) {
                    this.J.getWindow().setDimAmount(0.0f);
                }
                this.J.setContentView(relativeLayout);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        com.cmic.gen.sdk.f.c.a(f2138a, "loginClickStart");
    }

    public void c() {
        try {
            com.cmic.gen.sdk.f.c.a(f2138a, "loginClickComplete");
            if (this.E.getGenLoginClickListener() != null && this.H) {
                this.H = false;
                this.E.getGenLoginClickListener().onLoginClickComplete(this.d, null);
            } else {
                Dialog dialog = this.J;
                if (dialog != null && dialog.isShowing()) {
                    this.J.dismiss();
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean p() {
        return (TextUtils.isEmpty(this.E.getCheckTipText()) && this.E.getGenCheckBoxListener() == null && this.E.getPrivacyAnimation() == null && this.E.getGenAuthLoginListener() == null) ? false : true;
    }

    private static class b extends o.a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        WeakReference<GenLoginAuthActivity> f2154a;
        WeakReference<c> b;

        protected b(GenLoginAuthActivity genLoginAuthActivity, c cVar) {
            this.f2154a = new WeakReference<>(genLoginAuthActivity);
            this.b = new WeakReference<>(cVar);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public boolean b() {
            c cVar = this.b.get();
            if (this.f2154a.get() == null || cVar == null) {
                return false;
            }
            return cVar.a(false);
        }

        @Override // com.cmic.gen.sdk.f.o.a
        protected void a() {
            final GenLoginAuthActivity genLoginAuthActivity = this.f2154a.get();
            genLoginAuthActivity.o.a("logintype", 1);
            i.a(true, false);
            genLoginAuthActivity.p.b(genLoginAuthActivity.o, new com.cmic.gen.sdk.auth.b() { // from class: com.cmic.gen.sdk.view.GenLoginAuthActivity.b.1
                @Override // com.cmic.gen.sdk.auth.b
                public void a(String str, String str2, com.cmic.gen.sdk.a aVar, JSONObject jSONObject) {
                    if (b.this.b()) {
                        long jB = aVar.b("loginTime", 0L);
                        String strB = aVar.b("phonescrip");
                        if (jB != 0) {
                            aVar.a("loginTime", System.currentTimeMillis() - jB);
                        }
                        if (!"103000".equals(str) || TextUtils.isEmpty(strB)) {
                            genLoginAuthActivity.y = false;
                            com.cmic.gen.sdk.d.a.a("authClickFailed");
                        } else {
                            com.cmic.gen.sdk.d.a.a("authClickSuccess");
                            genLoginAuthActivity.y = true;
                        }
                        genLoginAuthActivity.a(str, str2, aVar, jSONObject);
                        try {
                            Thread.sleep(1000L);
                        } catch (InterruptedException e) {
                            e.printStackTrace();
                        }
                        genLoginAuthActivity.w.sendEmptyMessage(1);
                    }
                }
            });
        }
    }
}
