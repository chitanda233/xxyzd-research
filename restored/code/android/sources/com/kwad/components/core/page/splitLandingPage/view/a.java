package com.kwad.components.core.page.splitLandingPage.view;

import android.animation.Animator;
import android.animation.AnimatorSet;
import android.content.Context;
import android.graphics.Rect;
import android.os.SystemClock;
import android.text.TextUtils;
import android.util.DisplayMetrics;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.WindowManager;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.kwad.components.core.t.x;
import com.kwad.components.core.video.e;
import com.kwad.components.core.video.g;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.contentalliance.a.a.b;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.h;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.video.videoview.AdVideoPlayerViewCache;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private ViewGroup Dq;
    private ImageView OS;
    private WindowManager afF;
    private com.kwad.components.core.page.splitLandingPage.a.a afG;
    private FrameLayout afH;
    private FrameLayout afI;
    private e afJ;
    private final WindowManager.LayoutParams afK = new WindowManager.LayoutParams();
    private InterfaceC0452a afL;
    private com.kwad.sdk.core.video.videoview.a cB;
    private com.kwad.sdk.core.video.videoview.a.InterfaceC0519a cK;
    private ImageView ia;
    private Context mContext;

    /* JADX INFO: renamed from: com.kwad.components.core.page.splitLandingPage.view.a$a, reason: collision with other inner class name */
    public interface InterfaceC0452a {
        boolean vc();
    }

    public final void a(InterfaceC0452a interfaceC0452a) {
        this.afL = interfaceC0452a;
    }

    public a(Context context, com.kwad.components.core.page.splitLandingPage.a.a aVar) {
        if (context == null) {
            return;
        }
        Context contextWrapContextIfNeed = m.wrapContextIfNeed(context);
        this.mContext = contextWrapContextIfNeed;
        this.afG = aVar;
        WindowManager windowManager = (WindowManager) contextWrapContextIfNeed.getSystemService("window");
        this.afF = windowManager;
        if (windowManager == null) {
            return;
        }
        ViewGroup viewGroup = (ViewGroup) LayoutInflater.from(this.mContext).inflate(R.layout.ksad_split_mini_video, (ViewGroup) null);
        this.Dq = viewGroup;
        this.afH = (FrameLayout) viewGroup.findViewById(R.id.ksad_split_texture);
        this.afI = (FrameLayout) this.Dq.findViewById(R.id.ksad_video_container);
        this.ia = (ImageView) this.Dq.findViewById(R.id.ksad_video_first_frame_container);
        this.OS = (ImageView) this.Dq.findViewById(R.id.ksad_split_mini_close_btn);
        this.afH.setOnTouchListener(new View.OnTouchListener() { // from class: com.kwad.components.core.page.splitLandingPage.view.a.1
            float afM = 0.0f;
            float afN = 0.0f;
            float top = 0.0f;
            float left = 0.0f;
            long afO = 0;

            @Override // android.view.View.OnTouchListener
            public final boolean onTouch(View view, MotionEvent motionEvent) {
                if (a.this.afK == null) {
                    return false;
                }
                if (motionEvent.getActionMasked() == 0) {
                    this.afM = motionEvent.getRawX();
                    this.afN = motionEvent.getRawY();
                    this.left = a.this.afK.x;
                    this.top = a.this.afK.y;
                    this.afO = SystemClock.elapsedRealtime();
                    System.out.println(" actionDownX " + this.afM + " actionDownX " + this.afM);
                } else {
                    if (motionEvent.getActionMasked() == 2) {
                        float rawX = motionEvent.getRawX() - this.afM;
                        float rawY = motionEvent.getRawY() - this.afN;
                        if (Math.sqrt((rawX * rawX) + (rawY * rawY)) > 15.0d) {
                            a.this.afK.x = (int) (this.left + rawX);
                            a.this.afK.y = (int) (this.top + rawY);
                            if (a.this.afF != null) {
                                try {
                                    a.this.afF.updateViewLayout(a.this.Dq, a.this.afK);
                                } catch (Exception e) {
                                    com.kwad.components.core.d.a.reportSdkCaughtException(e);
                                    c.printStackTraceOnly(e);
                                }
                            }
                        }
                        return true;
                    }
                    if (motionEvent.getActionMasked() == 1) {
                        float rawX2 = motionEvent.getRawX() - this.afM;
                        float rawY2 = motionEvent.getRawY() - this.afN;
                        float fElapsedRealtime = SystemClock.elapsedRealtime() - this.afO;
                        if (Math.sqrt((rawX2 * rawX2) + (rawY2 * rawY2)) < 15.0d && fElapsedRealtime > 30.0f && fElapsedRealtime < 300.0f && a.this.afL != null && a.this.afG != null && com.kwad.sdk.core.response.helper.a.aL(com.kwad.sdk.core.response.helper.e.eM(a.this.afG.getAdTemplate()))) {
                            a.this.afL.vc();
                        }
                    }
                }
                return true;
            }
        });
    }

    public final void vb() {
        this.afJ.af();
    }

    public final boolean isVisible() {
        return this.Dq.getAlpha() > 0.0f;
    }

    public final boolean ve() {
        if (this.afG == null || this.afF == null) {
            return false;
        }
        c(new KsAdVideoPlayConfig.Builder().videoSoundEnable(this.afG.getAdTemplate().mIsAudioEnable).build());
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.afG.getAdTemplate());
        int iT = com.kwad.sdk.core.response.helper.a.T(adInfoEM);
        int iS = com.kwad.sdk.core.response.helper.a.S(adInfoEM);
        Rect rect = new Rect();
        DisplayMetrics displayMetrics = this.mContext.getResources().getDisplayMetrics();
        if (iT > iS) {
            rect.right = displayMetrics.widthPixels;
            rect.left = rect.right - com.kwad.sdk.c.a.a.a(this.mContext, 86.0f);
            rect.bottom = displayMetrics.heightPixels - com.kwad.sdk.c.a.a.a(this.mContext, 252.0f);
            rect.top = rect.bottom - com.kwad.sdk.c.a.a.a(this.mContext, 154.0f);
        } else {
            rect.right = displayMetrics.widthPixels;
            rect.left = rect.right - com.kwad.sdk.c.a.a.a(this.mContext, 154.0f);
            rect.bottom = displayMetrics.heightPixels - com.kwad.sdk.c.a.a.a(this.mContext, 252.0f);
            rect.top = rect.bottom - com.kwad.sdk.c.a.a.a(this.mContext, 86.0f);
        }
        rect.left -= com.kwad.sdk.c.a.a.a(this.mContext, 12.0f);
        rect.right -= com.kwad.sdk.c.a.a.a(this.mContext, 12.0f);
        this.afK.type = 1003;
        this.afK.flags = 8;
        this.afK.gravity = 51;
        this.afK.format = 1;
        this.afK.width = displayMetrics.widthPixels;
        this.afK.height = displayMetrics.heightPixels;
        this.afK.x = rect.left;
        this.afK.y = rect.top;
        this.afK.width = (rect.right - rect.left) + com.kwad.sdk.c.a.a.a(this.mContext, 12.0f);
        this.afK.height = (rect.bottom - rect.top) + com.kwad.sdk.c.a.a.a(this.mContext, 12.0f);
        float f = (rect.left * displayMetrics.widthPixels) / ((rect.left + displayMetrics.widthPixels) - rect.right);
        float f2 = (rect.top * displayMetrics.heightPixels) / ((rect.top + displayMetrics.heightPixels) - rect.bottom);
        this.Dq.setPivotX(f);
        this.Dq.setPivotY(f2);
        this.Dq.setAlpha(0.0f);
        if (this.afF != null) {
            try {
                if (this.Dq.getWindowToken() == null) {
                    this.afF.addView(this.Dq, this.afK);
                }
            } catch (Exception e) {
                com.kwad.components.core.d.a.reportSdkCaughtException(e);
                c.printStackTraceOnly(e);
            }
        }
        this.OS.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.core.page.splitLandingPage.view.a.2
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                a.this.vb();
                a.this.aV(false).start();
            }
        });
        return true;
    }

    private void c(KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        final AdTemplate adTemplate = this.afG.getAdTemplate();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        String url = com.kwad.sdk.core.response.helper.a.bA(adInfoEM).getUrl();
        if (!TextUtils.isEmpty(url)) {
            this.ia.setImageDrawable(null);
            KSImageLoader.loadImage(this.ia, url, adTemplate);
            this.ia.setVisibility(0);
        } else {
            this.ia.setVisibility(8);
        }
        String strM = com.kwad.sdk.core.response.helper.a.M(adInfoEM);
        if (TextUtils.isEmpty(strM)) {
            return;
        }
        com.kwad.sdk.core.video.videoview.a aVarFr = AdVideoPlayerViewCache.getInstance().fr(strM);
        this.cB = aVarFr;
        if (aVarFr == null) {
            this.cB = new com.kwad.sdk.core.video.videoview.a(this.mContext);
            com.kwad.sdk.core.response.helper.a.ae(adInfoEM);
            this.cB.a(new b.a(adTemplate).a(adTemplate.mVideoPlayerStatus).dO(com.kwad.sdk.core.response.helper.e.eO(adTemplate)).dP(h.b(com.kwad.sdk.core.response.helper.e.eN(adTemplate))).b(new com.kwad.sdk.contentalliance.a.a.a(adTemplate, System.currentTimeMillis())).IS(), null);
            com.kwad.sdk.core.video.videoview.a.InterfaceC0519a interfaceC0519a = new com.kwad.sdk.core.video.videoview.a.InterfaceC0519a() { // from class: com.kwad.components.core.page.splitLandingPage.view.a.3
                @Override // com.kwad.sdk.core.video.videoview.a.InterfaceC0519a
                public final com.kwad.sdk.core.video.a.c a(b bVar) {
                    if (!((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQq)).booleanValue() || !((Boolean) com.kwad.sdk.core.config.e.b(com.kwad.sdk.core.config.c.aQr)).booleanValue()) {
                        return null;
                    }
                    g gVar = new g(bVar, adTemplate);
                    if (g.isWaynePlayerReady()) {
                        return gVar;
                    }
                    return null;
                }
            };
            this.cK = interfaceC0519a;
            this.cB.setExternalPlayerListener(interfaceC0519a);
            this.cB.setVideoSoundEnable(ksAdVideoPlayConfig.isVideoSoundEnable());
            e eVar = new e(this.mContext, adTemplate, this.cB, ksAdVideoPlayConfig);
            this.afJ = eVar;
            eVar.setDataFlowAutoStart(ksAdVideoPlayConfig.isDataFlowAutoStart());
            this.cB.setController(this.afJ);
            this.afJ.setAutoRelease(false);
        } else {
            e eVar2 = (e) aVarFr.getController();
            this.afJ = eVar2;
            eVar2.setAutoRelease(false);
            this.afJ.getAdTemplate().mAdWebVideoPageShowing = true;
        }
        this.cB.setVideoSoundEnable(ksAdVideoPlayConfig.isVideoSoundEnable());
        if (this.cB.getParent() != null) {
            ((ViewGroup) this.cB.getParent()).removeView(this.cB);
        }
        if (this.afI.getTag() != null) {
            FrameLayout frameLayout = this.afI;
            frameLayout.removeView((View) frameLayout.getTag());
            this.afI.setTag(null);
        }
        this.afI.addView(this.cB);
        this.afI.setTag(this.cB);
        this.afJ.setAlpha(0.01f);
        this.afJ.setVideoPlayCallback(new com.kwad.components.core.video.a.c() { // from class: com.kwad.components.core.page.splitLandingPage.view.a.4
            @Override // com.kwad.components.core.video.a.c
            public final void as() {
            }

            @Override // com.kwad.components.core.video.a.c
            public final void d(long j) {
            }

            @Override // com.kwad.components.core.video.a.c
            public final void onVideoPlayStart() {
            }

            @Override // com.kwad.components.core.video.a.c
            public final void at() {
                a.this.vb();
                a.this.aV(false).start();
            }
        });
    }

    public final void vf() {
        com.kwad.sdk.core.video.videoview.a aVar = this.cB;
        if (aVar == null || aVar.isPlaying()) {
            return;
        }
        this.afJ.xS();
    }

    public final Animator aV(boolean z) {
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.playTogether(x.h(this.Dq, z), x.h(this.ia, z));
        return animatorSet;
    }
}
