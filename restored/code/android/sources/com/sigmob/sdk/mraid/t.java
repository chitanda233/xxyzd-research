package com.sigmob.sdk.mraid;

import android.content.Context;
import android.net.Uri;
import android.view.View;
import android.widget.FrameLayout;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.logger.SigmobLog;
import java.io.File;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class t extends n implements n.a, com.sigmob.sdk.videocache.d {
    public static final int c = 0;
    public static final int d = 1;
    public static final int e = 2;
    public static final int f = 3;
    public static final int g = 4;
    public static final int h = 0;
    public static final int i = 1;
    public static final int j = 2;
    public static final int k = 4;
    public static final int l = 8;
    private r m;
    private String n;
    private u o;

    /* JADX INFO: renamed from: com.sigmob.sdk.mraid.t$2, reason: invalid class name */
    static /* synthetic */ class AnonymousClass2 {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f3519a;

        static {
            int[] iArr = new int[com.sigmob.sdk.videoplayer.d.values().length];
            f3519a = iArr;
            try {
                iArr[com.sigmob.sdk.videoplayer.d.STATE_PREPARED.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f3519a[com.sigmob.sdk.videoplayer.d.STATE_ERROR.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f3519a[com.sigmob.sdk.videoplayer.d.STATE_PAUSE.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                f3519a[com.sigmob.sdk.videoplayer.d.STATE_PLAYING.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                f3519a[com.sigmob.sdk.videoplayer.d.STATE_AUTO_COMPLETE.ordinal()] = 5;
            } catch (NoSuchFieldError unused5) {
            }
            try {
                f3519a[com.sigmob.sdk.videoplayer.d.STATE_PREPARING.ordinal()] = 6;
            } catch (NoSuchFieldError unused6) {
            }
            try {
                f3519a[com.sigmob.sdk.videoplayer.d.STATE_BUFFERING_START.ordinal()] = 7;
            } catch (NoSuchFieldError unused7) {
            }
            try {
                f3519a[com.sigmob.sdk.videoplayer.d.STATE_BUFFERING_END.ordinal()] = 8;
            } catch (NoSuchFieldError unused8) {
            }
            try {
                f3519a[com.sigmob.sdk.videoplayer.d.STATE_STOP.ordinal()] = 9;
            } catch (NoSuchFieldError unused9) {
            }
        }
    }

    public t(String uniqueId) {
        super(uniqueId);
    }

    private void a(String uniqueId, String url) {
        Uri uri = Uri.parse(url);
        if (uri != null && "127.0.0.1".equalsIgnoreCase(uri.getHost())) {
            Pattern patternCompile = Pattern.compile("/(.*)");
            String path = uri.getPath();
            if (com.sigmob.sdk.base.utils.s.a((CharSequence) path)) {
                return;
            }
            Matcher matcher = patternCompile.matcher(path);
            if (matcher.find()) {
                this.n = matcher.group(1);
                com.sigmob.sdk.base.common.h.d().registerCacheListener(this, this.n);
            }
        }
    }

    @Override // com.sigmob.sdk.mraid.n
    public View a() {
        return this.m;
    }

    @Override // com.sigmob.sdk.mraid.n.a
    public void a(Context context, JSONObject args) {
        r rVar = new r(context);
        this.m = rVar;
        rVar.setVideoPlayerStatusListener(new com.sigmob.sdk.videoplayer.k() { // from class: com.sigmob.sdk.mraid.t.1
            @Override // com.sigmob.sdk.videoplayer.k
            public void a(long position, long duration) {
                if (t.this.o == null) {
                    return;
                }
                t.this.o.a(t.this.f3501a, position, duration);
            }

            @Override // com.sigmob.sdk.videoplayer.k
            public void a(com.sigmob.sdk.videoplayer.d state) {
                u uVar;
                String str;
                SigmobLog.d("VIDEO_PLAYER_STATE change: " + state);
                int i2 = 1;
                switch (AnonymousClass2.f3519a[state.ordinal()]) {
                    case 1:
                        if (t.this.o != null) {
                            t.this.o.a(t.this.f3501a, t.this.m.getDuration(), t.this.m.getVideoWidth(), t.this.m.getVideoHeight());
                        }
                        if (t.this.o != null) {
                            t.this.o.b(t.this.f3501a, 2);
                        }
                        if (t.this.o != null) {
                            t.this.o.b(t.this.f3501a, 4);
                            return;
                        }
                        return;
                    case 2:
                        if (t.this.o != null) {
                            t.this.o.a(t.this.f3501a, t.this.m.getErrorCode(), t.this.m.getErrorMessage());
                            return;
                        }
                        return;
                    case 3:
                        if (t.this.o != null) {
                            t.this.o.a(t.this.f3501a, 2);
                            return;
                        }
                        return;
                    case 4:
                        if (t.this.o != null) {
                            t.this.o.a(t.this.f3501a, 1);
                            return;
                        }
                        return;
                    case 5:
                        if (t.this.o != null) {
                            t.this.o.a(t.this.f3501a, t.this.m.getDuration(), t.this.m.getDuration());
                            t.this.o.a(t.this.f3501a, t.this.m.getDuration());
                            return;
                        }
                        return;
                    case 6:
                        if (t.this.o == null) {
                            return;
                        }
                        uVar = t.this.o;
                        str = t.this.f3501a;
                        break;
                    case 7:
                        if (t.this.o == null) {
                            return;
                        }
                        t.this.m.j();
                        uVar = t.this.o;
                        str = t.this.f3501a;
                        i2 = 8;
                        break;
                    case 8:
                        if (t.this.o != null) {
                            t.this.m.d();
                            t.this.o.b(t.this.f3501a, 2);
                            return;
                        }
                        return;
                    case 9:
                        if (t.this.o != null) {
                            t.this.o.a(t.this.f3501a, 4);
                            return;
                        }
                        return;
                    default:
                        return;
                }
                uVar.b(str, i2);
            }
        });
    }

    public void a(u mraidVpaidListener) {
        this.o = mraidVpaidListener;
    }

    @Override // com.sigmob.sdk.videocache.d
    public void a(File cacheFile, String url, int percentsAvailable) {
    }

    @Override // com.sigmob.sdk.videocache.d
    public void a(String url, Throwable throwable) {
        SigmobLog.e("url", throwable);
        u uVar = this.o;
        if (uVar == null) {
            return;
        }
        uVar.a(this.f3501a, 0, throwable.getMessage());
    }

    @Override // com.sigmob.sdk.mraid.n.a
    public void a(JSONObject args) {
        if (this.m == null) {
            return;
        }
        String strOptString = args.optString("URL");
        if (args.optBoolean("proxy", false) && com.sigmob.sdk.base.utils.s.b(strOptString) && strOptString.startsWith("http")) {
            Uri uri = Uri.parse(strOptString);
            if (uri != null && !"127.0.0.1".equalsIgnoreCase(uri.getHost())) {
                strOptString = com.sigmob.sdk.base.common.h.d().getProxyUrl(strOptString);
            }
            a(this.f3501a, strOptString);
        }
        this.m.setUp(strOptString);
        this.m.n();
    }

    @Override // com.sigmob.sdk.mraid.n
    public void b() {
        if (com.sigmob.sdk.base.utils.v.b(this.m)) {
            com.sigmob.sdk.base.utils.w.a(this.m);
            this.m.removeAllViews();
            this.m.r();
            this.m = null;
        }
        if (com.sigmob.sdk.base.utils.s.b(this.n)) {
            com.sigmob.sdk.base.common.h.d().unregisterCacheListener(this, this.n);
        }
    }

    @Override // com.sigmob.sdk.mraid.n.a
    public void b(JSONObject args) {
        r rVar = this.m;
        if (rVar == null) {
            return;
        }
        rVar.d();
    }

    @Override // com.sigmob.sdk.mraid.n.a
    public void c(JSONObject args) {
        r rVar = this.m;
        if (rVar == null) {
            return;
        }
        rVar.a(0);
        this.m.d();
    }

    @Override // com.sigmob.sdk.mraid.n.a
    public void d(JSONObject args) {
        r rVar = this.m;
        if (rVar == null) {
            return;
        }
        rVar.j();
    }

    @Override // com.sigmob.sdk.mraid.n.a
    public void e(JSONObject args) {
        r rVar = this.m;
        if (rVar == null) {
            return;
        }
        rVar.i();
    }

    @Override // com.sigmob.sdk.mraid.n.a
    public void f(JSONObject args) {
        if (this.m == null) {
            return;
        }
        this.m.setMute(args.optBoolean("muted", false));
    }

    @Override // com.sigmob.sdk.mraid.n.a
    public void g(JSONObject args) {
        if (this.m == null) {
            return;
        }
        this.m.a(((int) args.optDouble("seekTime", 0.0d)) * 1000);
    }

    @Override // com.sigmob.sdk.mraid.n.a
    public void h(JSONObject args) {
        JSONObject jSONObjectOptJSONObject;
        if (this.m == null || args == null || (jSONObjectOptJSONObject = args.optJSONObject("frame")) == null) {
            return;
        }
        Context contextE = com.sigmob.sdk.b.e();
        int iOptDouble = (int) jSONObjectOptJSONObject.optDouble("x", 0.0d);
        int iOptDouble2 = (int) jSONObjectOptJSONObject.optDouble("y", 0.0d);
        int iOptDouble3 = (int) jSONObjectOptJSONObject.optDouble(IAdInterListener.AdReqParam.WIDTH, -1.0d);
        int iOptDouble4 = (int) jSONObjectOptJSONObject.optDouble("h", -1.0d);
        if (iOptDouble3 > 0) {
            iOptDouble3 = Dips.dipsToIntPixels(iOptDouble3, contextE);
        }
        if (iOptDouble4 > 0) {
            iOptDouble4 = Dips.dipsToIntPixels(iOptDouble4, contextE);
        }
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(iOptDouble3, iOptDouble4);
        this.m.setX(Dips.dipsToIntPixels(iOptDouble, contextE));
        this.m.setY(Dips.dipsToIntPixels(iOptDouble2, contextE));
        this.m.setLayoutParams(layoutParams);
        this.m.requestLayout();
    }
}
