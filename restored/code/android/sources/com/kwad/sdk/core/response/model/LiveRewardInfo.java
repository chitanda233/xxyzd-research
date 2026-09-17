package com.kwad.sdk.core.response.model;

import java.io.Serializable;

/* JADX INFO: loaded from: classes3.dex */
public class LiveRewardInfo extends com.kwad.sdk.core.response.a.a implements Serializable {
    private static final long serialVersionUID = 3720115328871870367L;
    public long rewardTimeSecond = 0;
    public long rewardAmount = 0;
    public int rewardType = 0;
    public boolean rewardVerified = false;

    public boolean isValid() {
        return this.rewardTimeSecond > 0 && this.rewardAmount > 0;
    }
}
