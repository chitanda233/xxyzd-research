package com.google.android.gms.internal.play_billing;

import android.os.SystemClock;
import com.bykv.vk.component.ttvideo.player.C;

/* JADX INFO: compiled from: com.android.billingclient:billing@@8.0.0 */
/* JADX INFO: loaded from: classes3.dex */
final class zzay extends zzbl {
    zzay() {
    }

    @Override // com.google.android.gms.internal.play_billing.zzbl
    public final long zza() {
        return SystemClock.elapsedRealtime() * C.MICROS_PER_SECOND;
    }
}
