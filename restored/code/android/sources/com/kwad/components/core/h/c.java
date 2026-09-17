package com.kwad.components.core.h;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.kwad.components.core.video.i;
import com.kwad.sdk.core.imageloader.core.assist.FailReason;
import com.kwad.sdk.core.imageloader.core.decode.DecodedResult;
import com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener;
import java.io.InputStream;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements ImageLoadingListener {
    private b Sr;
    private a Ss;
    private long Sv;
    private long kq;
    private int St = 1;
    private int Su = 16;
    private List<i> Sw = new CopyOnWriteArrayList();

    @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
    public final boolean onDecode(String str, InputStream inputStream, DecodedResult decodedResult) {
        return false;
    }

    @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
    public final void onLoadingCancelled(String str, View view) {
    }

    @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
    public final void onLoadingComplete(String str, View view, DecodedResult decodedResult) {
    }

    @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
    public final void onLoadingStarted(String str, View view) {
    }

    static /* synthetic */ int a(c cVar, FailReason.FailType failType) {
        return a(failType);
    }

    public c() {
        a aVar = new a(new Handler(Looper.getMainLooper()));
        this.Ss = aVar;
        aVar.a(new a.InterfaceC0429a() { // from class: com.kwad.components.core.h.c.1
            private boolean Sx = false;
            private boolean Sy = false;

            @Override // com.kwad.components.core.h.a.InterfaceC0429a
            public final void D(final long j) {
                com.kwad.sdk.core.d.c.d("KSImagePlayer", "onTimerProgress: " + j);
                if (j == 0) {
                    qY();
                }
                c.this.kq = j;
                c.this.c(new com.kwad.sdk.g.a<i>() { // from class: com.kwad.components.core.h.c.1.1
                    /* JADX INFO: Access modifiers changed from: private */
                    @Override // com.kwad.sdk.g.a
                    /* JADX INFO: renamed from: e, reason: merged with bridge method [inline-methods] */
                    public void accept(i iVar) {
                        iVar.onMediaPlayProgress(c.this.Sv, j);
                    }
                });
                if (c.this.kq < c.this.Sv || c.this.Sv <= 0) {
                    return;
                }
                mz();
            }

            private void mz() {
                if (this.Sx) {
                    return;
                }
                c.this.c(new com.kwad.sdk.g.a<i>() { // from class: com.kwad.components.core.h.c.1.2
                    @Override // com.kwad.sdk.g.a
                    public final /* synthetic */ void accept(i iVar) {
                        e(iVar);
                    }

                    private static void e(i iVar) {
                        iVar.onMediaPlayCompleted();
                    }
                });
                this.Sx = true;
            }

            private void qY() {
                if (this.Sy) {
                    return;
                }
                com.kwad.sdk.core.d.c.d("KSImagePlayer", "onFirstFrame: ");
                this.Sy = true;
                c.this.c(new com.kwad.sdk.g.a<i>() { // from class: com.kwad.components.core.h.c.1.3
                    @Override // com.kwad.sdk.g.a
                    public final /* synthetic */ void accept(i iVar) {
                        e(iVar);
                    }

                    private static void e(i iVar) {
                        iVar.onMediaPlayStart();
                    }
                });
            }
        });
    }

    public final FrameLayout getImagePlayerView(Context context) {
        if (this.Sr == null) {
            this.Sr = new b(context);
        }
        return this.Sr;
    }

    public final void setRadius(float f, float f2, float f3, float f4) {
        b bVar = this.Sr;
        if (bVar != null) {
            bVar.setRadius(f, f2, f3, f4);
        }
    }

    public final void setURLs(List<String> list) {
        if (list == null || list.size() == 0) {
            return;
        }
        String str = list.get(0);
        b bVar = this.Sr;
        if (bVar != null) {
            bVar.a(str, this);
        }
    }

    public final void E(long j) {
        this.Sv = j;
    }

    public final void setImageScaleType(ImageView.ScaleType scaleType) {
        b bVar = this.Sr;
        if (bVar != null) {
            bVar.setImageScaleType(scaleType);
        }
    }

    public final void setVerticalGravity(int i) {
        this.Su = com.kwad.components.core.b.c.ay(i);
        qX();
    }

    public final void setHorizontalGravity(int i) {
        this.Su = com.kwad.components.core.b.c.az(i);
        qX();
    }

    public final void play() {
        a aVar = this.Ss;
        if (aVar != null) {
            aVar.start();
        }
    }

    public final void pause() {
        a aVar = this.Ss;
        if (aVar != null) {
            aVar.pause();
        }
        c(new com.kwad.sdk.g.a<i>() { // from class: com.kwad.components.core.h.c.2
            @Override // com.kwad.sdk.g.a
            public final /* synthetic */ void accept(i iVar) {
                e(iVar);
            }

            private static void e(i iVar) {
                iVar.onMediaPlayPaused();
            }
        });
    }

    public final void resume() {
        a aVar = this.Ss;
        if (aVar != null) {
            aVar.resume();
            c(new com.kwad.sdk.g.a<i>() { // from class: com.kwad.components.core.h.c.3
                @Override // com.kwad.sdk.g.a
                public final /* synthetic */ void accept(i iVar) {
                    e(iVar);
                }

                private static void e(i iVar) {
                    iVar.onMediaPlaying();
                }
            });
        }
    }

    public final void stop() {
        a aVar = this.Ss;
        if (aVar != null) {
            aVar.stop();
        }
    }

    public final void skipToEnd() {
        c(new com.kwad.sdk.g.a<i>() { // from class: com.kwad.components.core.h.c.4
            @Override // com.kwad.sdk.g.a
            public final /* synthetic */ void accept(i iVar) {
                e(iVar);
            }

            private static void e(i iVar) {
                iVar.onMediaPlayCompleted();
            }
        });
    }

    public final long getPlayDuration() {
        return this.kq;
    }

    public final void c(i iVar) {
        if (iVar != null) {
            this.Sw.add(iVar);
        }
    }

    public final void d(i iVar) {
        if (iVar != null) {
            this.Sw.remove(iVar);
        }
    }

    public final void destroy() {
        this.Sw.clear();
        b bVar = this.Sr;
        if (bVar != null && bVar.getParent() != null) {
            ((ViewGroup) this.Sr.getParent()).removeView(this.Sr);
        }
        this.Sr = null;
        a aVar = this.Ss;
        if (aVar != null) {
            aVar.destroy();
            this.Ss = null;
        }
    }

    public final void setSpeed(float f) {
        a aVar = this.Ss;
        if (aVar != null) {
            aVar.setSpeed(f);
        }
    }

    private void qX() {
        b bVar = this.Sr;
        if (bVar != null) {
            bVar.setImageGravity(this.St | this.Su);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public <T> void c(com.kwad.sdk.g.a<i> aVar) {
        List<i> list;
        if (aVar == null || (list = this.Sw) == null) {
            return;
        }
        Iterator<i> it = list.iterator();
        while (it.hasNext()) {
            aVar.accept(it.next());
        }
    }

    @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
    public final void onLoadingFailed(String str, View view, final FailReason failReason) {
        c(new com.kwad.sdk.g.a<i>() { // from class: com.kwad.components.core.h.c.5
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.g.a
            /* JADX INFO: renamed from: e, reason: merged with bridge method [inline-methods] */
            public void accept(i iVar) {
                iVar.onMediaPlayError(-1, c.a(c.this, failReason.getType()));
            }
        });
    }

    /* JADX INFO: renamed from: com.kwad.components.core.h.c$6, reason: invalid class name */
    static /* synthetic */ class AnonymousClass6 {
        static final /* synthetic */ int[] $SwitchMap$com$kwad$sdk$core$imageloader$core$assist$FailReason$FailType;

        static {
            int[] iArr = new int[FailReason.FailType.values().length];
            $SwitchMap$com$kwad$sdk$core$imageloader$core$assist$FailReason$FailType = iArr;
            try {
                iArr[FailReason.FailType.IO_ERROR.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                $SwitchMap$com$kwad$sdk$core$imageloader$core$assist$FailReason$FailType[FailReason.FailType.DECODING_ERROR.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                $SwitchMap$com$kwad$sdk$core$imageloader$core$assist$FailReason$FailType[FailReason.FailType.NETWORK_DENIED.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                $SwitchMap$com$kwad$sdk$core$imageloader$core$assist$FailReason$FailType[FailReason.FailType.OUT_OF_MEMORY.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
            try {
                $SwitchMap$com$kwad$sdk$core$imageloader$core$assist$FailReason$FailType[FailReason.FailType.UNKNOWN.ordinal()] = 5;
            } catch (NoSuchFieldError unused5) {
            }
        }
    }

    private static int a(FailReason.FailType failType) {
        int i = AnonymousClass6.$SwitchMap$com$kwad$sdk$core$imageloader$core$assist$FailReason$FailType[failType.ordinal()];
        if (i == 1) {
            return -2;
        }
        if (i == 2) {
            return -3;
        }
        if (i != 3) {
            return i != 4 ? -1 : -5;
        }
        return -4;
    }
}
