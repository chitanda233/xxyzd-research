package com.unity3d.player;

import android.os.Handler;
import android.os.Looper;
import android.os.Message;

/* JADX INFO: loaded from: classes4.dex */
final class T0 implements Handler.Callback {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ U0 f4015a;

    T0(U0 u0) {
        this.f4015a = u0;
    }

    /* JADX WARN: Code duplicated, block: B:59:0x00e1 A[PHI: r7
  0x00e1: PHI (r7v11 com.unity3d.player.U0) = (r7v7 com.unity3d.player.U0), (r7v14 com.unity3d.player.U0) binds: [B:58:0x00df, B:47:0x00bd] A[DONT_GENERATE, DONT_INLINE]] */
    @Override // android.os.Handler.Callback
    public final boolean handleMessage(Message message) {
        U0 u0;
        if (message.what != 2269) {
            return false;
        }
        S0 s0 = (S0) message.obj;
        S0 s1 = S0.h;
        if (s0 == s1) {
            U0 u1 = this.f4015a;
            u1.e--;
            u1.i.executeGLThreadJobs();
            U0 u2 = this.f4015a;
            if (!u2.b) {
                return true;
            }
            if (u2.i.getHaveAndroidWindowSupport() && !this.f4015a.c) {
                return true;
            }
            U0 u3 = this.f4015a;
            int i = u3.h;
            if (i >= 0) {
                if (i == 0) {
                    if (u3.i.getSplashEnabled()) {
                        this.f4015a.i.DisableStaticSplashScreen();
                    }
                    UnityPlayer unityPlayer = this.f4015a.i;
                    if (unityPlayer.mActivity != null && unityPlayer.getAutoReportFullyDrawnEnabled()) {
                        this.f4015a.i.mActivity.reportFullyDrawn();
                    }
                }
                this.f4015a.h--;
            }
            if (!this.f4015a.i.isFinishing() && !this.f4015a.i.nativeRender()) {
                this.f4015a.i.finish();
            }
        } else if (s0 == S0.c) {
            Looper.myLooper().quit();
        } else if (s0 == S0.b) {
            this.f4015a.b = true;
        } else if (s0 == S0.f4013a) {
            this.f4015a.b = false;
        } else if (s0 == S0.d) {
            this.f4015a.c = false;
        } else if (s0 == S0.e) {
            u0 = this.f4015a;
            u0.c = true;
            if (u0.d == 3) {
                u0.i.nativeFocusChanged(true);
                this.f4015a.d = 1;
            }
        } else if (s0 == S0.f) {
            U0 u4 = this.f4015a;
            if (u4.d == 1) {
                u4.i.nativeFocusChanged(false);
            }
            this.f4015a.d = 2;
        } else if (s0 == S0.g) {
            u0 = this.f4015a;
            u0.d = 3;
            if (u0.c) {
                u0.i.nativeFocusChanged(true);
                this.f4015a.d = 1;
            }
        } else if (s0 == S0.i) {
            UnityPlayer unityPlayer2 = this.f4015a.i;
            unityPlayer2.nativeSetLaunchURL(unityPlayer2.getLaunchURL());
        } else if (s0 == S0.j) {
            U0 u5 = this.f4015a;
            u5.i.nativeOrientationChanged(u5.f, u5.g);
        }
        U0 u6 = this.f4015a;
        if (u6.b && u6.e <= 0) {
            Message.obtain(u6.f4017a, 2269, s1).sendToTarget();
            this.f4015a.e++;
        }
        return true;
    }
}
