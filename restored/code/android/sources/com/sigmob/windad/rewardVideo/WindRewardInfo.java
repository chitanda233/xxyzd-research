package com.sigmob.windad.rewardVideo;

import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public class WindRewardInfo {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final boolean f3710a;
    private HashMap<String, String> b;

    public WindRewardInfo(boolean isReward) {
        this.f3710a = isReward;
    }

    public WindRewardInfo(boolean isReward, HashMap<String, String> options) {
        this.f3710a = isReward;
        this.b = options;
    }

    public HashMap<String, String> getOptions() {
        return this.b;
    }

    public boolean isReward() {
        return this.f3710a;
    }

    public void setOptions(HashMap<String, String> options) {
        this.b = options;
    }

    public String toString() {
        return "WindRewardInfo{isReward=" + this.f3710a + ", options=" + this.b + '}';
    }
}
