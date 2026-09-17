package com.sigmob.sdk.base.views;

import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.os.Build;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowInsets;
import android.view.WindowManager;
import android.widget.RelativeLayout;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.PlacementType;
import com.sigmob.windad.WindAdError;
import java.net.URI;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class z extends Dialog implements DialogInterface.OnShowListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected com.sigmob.sdk.base.common.v f3365a;
    private View b;
    private Window c;
    private a d;
    private RelativeLayout e;
    private com.sigmob.sdk.videoAd.a f;
    private BaseAdUnit g;
    private com.sigmob.sdk.mraid.h h;
    private Context i;
    private int j;
    private int k;
    private boolean l;

    public interface a {
        void onCloseClick();
    }

    public z(Context context, BaseAdUnit adUnit, com.sigmob.sdk.videoAd.a videoConfig) {
        super(context, com.sigmob.sdk.base.k.e());
        this.c = null;
        this.j = 0;
        this.k = 0;
        this.l = false;
        this.i = context.getApplicationContext();
        this.g = adUnit;
        this.f = videoConfig;
        this.b = b();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(com.sigmob.sdk.mraid.v vVar, com.sigmob.sdk.base.common.v vVar2) {
        if (vVar2 != null) {
            this.f3365a = vVar2;
            return;
        }
        com.sigmob.sdk.base.common.v vVar3 = new com.sigmob.sdk.base.common.v();
        this.f3365a = vVar3;
        vVar3.a(this.g);
    }

    private void d() {
        Window window = getWindow();
        this.c = window;
        if (window == null) {
            return;
        }
        window.setGravity(80);
        int iG = com.sigmob.sdk.base.k.g();
        if (iG != 0) {
            this.c.setWindowAnimations(iG);
        }
        this.c.getDecorView().setPadding(0, 0, 0, 0);
        WindowManager.LayoutParams attributes = this.c.getAttributes();
        int i = this.i.getResources().getDisplayMetrics().widthPixels;
        int i2 = this.i.getResources().getDisplayMetrics().heightPixels;
        int i3 = this.k;
        if (i3 - 1 <= i) {
            attributes.width = -1;
        } else {
            attributes.width = i3;
        }
        int i4 = this.j;
        if (i4 - 1 <= i2) {
            attributes.height = -1;
        } else {
            attributes.height = i4;
        }
        SigmobLog.i("RecommendDialog windowDeploy: " + i + "====" + i2 + "====" + attributes.width + "====" + attributes.height);
        this.c.setAttributes(attributes);
    }

    public void a(a closeClickListener) {
        this.d = closeClickListener;
    }

    public void a(String event) {
        com.sigmob.sdk.base.common.v vVar = this.f3365a;
        if (vVar == null) {
            return;
        }
        vVar.a(event, 0);
    }

    public boolean a() {
        if (this.k <= 0 || this.j <= 0) {
            this.l = true;
        }
        return this.l;
    }

    public View b() {
        if (this.h == null) {
            this.h = new com.sigmob.sdk.mraid.h(this.i, this.g, PlacementType.INTERSTITIAL);
        }
        this.h.a(new com.sigmob.sdk.mraid.h.f() { // from class: com.sigmob.sdk.base.views.z.1
            @Override // com.sigmob.sdk.mraid.h.f
            public void a() {
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void a(Integer duration) {
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void a(Map<String, String> params) {
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void b() {
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void b(Map<String, String> params) {
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void c() {
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void d() {
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void e() {
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void f() {
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void g() {
            }

            @Override // com.sigmob.sdk.mraid.h.f
            public void h() {
            }
        });
        this.h.a(new com.sigmob.sdk.mraid.h.a() { // from class: com.sigmob.sdk.base.views.z.2
            private int i() {
                WindowInsets rootWindowInsets;
                if (Build.VERSION.SDK_INT < 28 || (rootWindowInsets = z.this.getWindow().getDecorView().getRootWindowInsets()) == null || rootWindowInsets.getDisplayCutout() == null) {
                    return 0;
                }
                return rootWindowInsets.getDisplayCutout().getSafeInsetTop();
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a() {
                SigmobLog.d("RecommendDialog onEndCardShow()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(float cvTime) {
                SigmobLog.d("RecommendDialog onReward()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(int width, int height, int offsetX, int offsetY, com.sigmob.sdk.mraid.b.a closePosition, boolean allowOffscreen) {
                int i = z.this.i.getResources().getDisplayMetrics().widthPixels;
                int i2 = z.this.i.getResources().getDisplayMetrics().heightPixels;
                int iM = com.sigmob.sdk.videoplayer.c.m(z.this.getContext());
                int i3 = i();
                SigmobLog.i("RecommendDialog Origin onResize :" + width + "==" + height + "==" + offsetX + "==" + offsetY + "==" + allowOffscreen);
                z zVar = z.this;
                zVar.k = Dips.dipsToIntPixels(width, zVar.i);
                z zVar2 = z.this;
                zVar2.j = Dips.dipsToIntPixels(height, zVar2.i);
                int iDipsToIntPixels = Dips.dipsToIntPixels(offsetX, z.this.i);
                int iDipsToIntPixels2 = Dips.dipsToIntPixels(offsetY, z.this.i) - Math.max(iM, i3);
                if (z.this.b == null) {
                    return;
                }
                if (!allowOffscreen) {
                    iDipsToIntPixels = Math.min(Math.max(iDipsToIntPixels, 0), i);
                    iDipsToIntPixels2 = Math.min(Math.max(iDipsToIntPixels2, 0), i2);
                    if (z.this.k + iDipsToIntPixels > i) {
                        z.this.k = i - iDipsToIntPixels;
                    }
                    if (z.this.j + iDipsToIntPixels2 > i2) {
                        z.this.j = i2 - iDipsToIntPixels2;
                    }
                }
                SigmobLog.i("RecommendDialog onResize: " + z.this.k + "==" + z.this.j + "==" + iDipsToIntPixels + "==" + iDipsToIntPixels2);
                if (z.this.k <= 0 || z.this.j <= 0) {
                    z.this.l = true;
                }
                z.this.b.setX(iDipsToIntPixels);
                z.this.b.setY(iDipsToIntPixels2);
                RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(z.this.k, z.this.j);
                layoutParams.addRule(12);
                z.this.b.setLayoutParams(layoutParams);
                z.this.b.requestLayout();
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(View view) {
                SigmobLog.d("RecommendDialog onLoaded()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(final WindAdError error) {
                SigmobLog.i("RecommendDialog onRenderProcessGone:" + error.toString());
                z.this.l = true;
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(String ext) {
                SigmobLog.i("RecommendDialog onCompanionClick:" + ext);
                boolean z = true;
                if (com.sigmob.sdk.base.utils.s.b(ext)) {
                    try {
                        JSONObject jSONObject = new JSONObject(ext);
                        int iOptInt = jSONObject.optInt("type");
                        z.this.h.a(String.valueOf(jSONObject.optInt("x")), String.valueOf(jSONObject.optInt("y")));
                        if (iOptInt == 1) {
                            z = false;
                        } else {
                            z.this.a(com.sigmob.sdk.base.common.a.s);
                        }
                    } catch (Exception unused) {
                        z.this.h.a("0", "0");
                        z.this.a(com.sigmob.sdk.base.common.a.s);
                    }
                }
                z.this.f.a(com.sigmob.sdk.base.a.ENDCARD, z.this.h.a(), z);
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(URI uri, int type, String ext) {
                boolean z;
                JSONObject jSONObject;
                boolean z2;
                boolean z3;
                SigmobLog.i("RecommendDialog  onOpen:" + uri + "======" + type + "=====" + ext);
                boolean z4 = false;
                JSONObject jSONObject2 = null;
                if (com.sigmob.sdk.base.utils.s.b(ext)) {
                    try {
                        jSONObject2 = new JSONObject(ext);
                        try {
                            int iOptInt = jSONObject2.optInt("type");
                            int iOptInt2 = jSONObject2.optInt("x");
                            int iOptInt3 = jSONObject2.optInt("y");
                            boolean zOptBoolean = jSONObject2.optBoolean("disable_landing");
                            try {
                                z = !jSONObject2.optBoolean("feDisable");
                                try {
                                    z.this.h.a(String.valueOf(iOptInt2), String.valueOf(iOptInt3));
                                    if (iOptInt != 1) {
                                        z.this.a("click");
                                        z4 = true;
                                    }
                                    jSONObject = jSONObject2;
                                    z2 = z;
                                    z3 = z4;
                                    z4 = zOptBoolean;
                                } catch (Exception unused) {
                                    z4 = zOptBoolean;
                                    z.this.h.a("0", "0");
                                    z.this.a("click");
                                    jSONObject = jSONObject2;
                                    z2 = z;
                                    z3 = true;
                                }
                            } catch (Exception unused2) {
                                z = true;
                            }
                        } catch (Exception unused3) {
                            jSONObject2 = jSONObject2;
                            z = true;
                            z.this.h.a("0", "0");
                            z.this.a("click");
                            jSONObject = jSONObject2;
                            z2 = z;
                            z3 = true;
                            if (z4) {
                            }
                            z.this.f.a(com.sigmob.sdk.base.a.ENDCARD, uri.toString(), z.this.h.a(), z3, z2, jSONObject);
                        }
                    } catch (Exception unused4) {
                    }
                } else {
                    z.this.h.a("0", "0");
                    z.this.a("click");
                    z3 = true;
                    z2 = true;
                    jSONObject = null;
                }
                if (!z4 || com.sigmob.sdk.base.utils.s.a((CharSequence) z.this.g.getLanding_page())) {
                    z.this.f.a(com.sigmob.sdk.base.a.ENDCARD, uri.toString(), z.this.h.a(), z3, z2, jSONObject);
                } else {
                    z.this.f.a(com.sigmob.sdk.base.a.ENDCARD, (String) null, z.this.h.a(), z3, z2);
                }
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void a(boolean isMute) {
                SigmobLog.d("RecommendDialog onMute()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void b() {
                SigmobLog.d("RecommendDialog onShowSkipTime()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void b(float progress) {
                SigmobLog.d("RecommendDialog onSkip()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void c() {
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void d() {
                SigmobLog.d("RecommendDialog onExpand()");
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void e() {
                SigmobLog.i("RecommendDialog onFailedToLoad()");
                z.this.l = true;
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void f() {
                SigmobLog.i("RecommendDialog onUnload()");
                z.this.dismiss();
                z.this.a(com.sigmob.sdk.base.common.a.e);
                z.this.c();
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void g() {
            }

            @Override // com.sigmob.sdk.mraid.h.a
            public void h() {
                SigmobLog.i("RecommendDialog onClose()");
                if (z.this.d != null) {
                    z.this.d.onCloseClick();
                }
            }
        });
        String closeCardHtmlData = this.g.getCloseCardHtmlData();
        if (com.sigmob.sdk.base.utils.s.b(closeCardHtmlData)) {
            this.h.a(closeCardHtmlData, new com.sigmob.sdk.mraid.h.b() { // from class: com.sigmob.sdk.base.views.z$$ExternalSyntheticLambda0
                @Override // com.sigmob.sdk.mraid.h.b
                public final void onReady(com.sigmob.sdk.mraid.v vVar, com.sigmob.sdk.base.common.v vVar2) {
                    this.f$0.a(vVar, vVar2);
                }
            });
        }
        return this.h.q();
    }

    public void c() {
        com.sigmob.sdk.mraid.h hVar = this.h;
        if (hVar == null) {
            return;
        }
        this.d = null;
        hVar.m();
        this.h = null;
    }

    @Override // android.app.Dialog
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        RelativeLayout relativeLayout = new RelativeLayout(getContext());
        this.e = relativeLayout;
        relativeLayout.setLayoutParams(new RelativeLayout.LayoutParams(-1, -1));
        this.e.setBackgroundColor(0);
        setContentView(this.e);
        setOnShowListener(this);
        SigmobLog.i("RecommendDialog onCreate:" + this.k + ":" + this.j);
        View view = this.b;
        if (view != null) {
            this.e.addView(view);
        }
        setCanceledOnTouchOutside(false);
        setCancelable(true);
        d();
    }

    @Override // android.content.DialogInterface.OnShowListener
    public void onShow(DialogInterface dialog) {
        SigmobLog.i("RecommendDialog  onShow");
        a(com.sigmob.sdk.base.common.a.d);
        this.h.a(0);
    }

    @Override // android.app.Dialog
    protected void onStart() {
        super.onStart();
        Window window = getWindow();
        this.c = window;
        com.sigmob.sdk.videoplayer.c.a(window);
    }
}
